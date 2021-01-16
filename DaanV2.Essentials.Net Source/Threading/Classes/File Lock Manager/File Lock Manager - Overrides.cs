﻿/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.


THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/

using System;
using System.Collections.Generic;

namespace DaanV2.Threading {
    public sealed partial class FileLockManager : IEquatable<FileLockManager> {
        /// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
        /// <param name="obj">The object to check against.</param>
        /// <returns>Returns a value that indicates whether this instance is equal to a specified object.</returns>
        public override Boolean Equals(Object obj) {
            return this.Equals(obj as FileLockManager);
        }

        /// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
        /// <param name="other">The object to check against.</param>
        /// <returns>Returns a value that indicates whether this instance is equal to a specified object.</returns>
        public Boolean Equals(FileLockManager other) {
            return other != null &&
                   this._RootCount == other._RootCount &&
                   this._LockPerRootCount == other._LockPerRootCount &&
                   EqualityComparer<LockPool[]>.Default.Equals(this._DriveLocks, other._DriveLocks);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>Returns the hash code for this instance.</returns>
        public override Int32 GetHashCode() {
#if NETCORE
            return HashCode.Combine(this._DriveLocks, this._RootCount, this._LockPerRootCount);
#else
            Int32 hashCode = 994238770;
            hashCode = hashCode * -1521134295 + EqualityComparer<LockPool[]>.Default.GetHashCode(this._DriveLocks);
            hashCode = hashCode * -1521134295 + this._RootCount.GetHashCode();
            hashCode = hashCode * -1521134295 + this._LockPerRootCount.GetHashCode();
            return hashCode;
#endif
        }

        /// <summary>Compare two <see cref="PriorityAttribute"/> if they are equal to each other.</summary>
        /// <param name="left">The first <see cref="PriorityAttribute"/> to check.</param>
        /// <param name="right">The second <see cref="PriorityAttribute"/> to check.</param>
        /// <returns>Compare two <see cref="PriorityAttribute"/> if they are equal to each other.</returns>
        public static Boolean operator ==(FileLockManager left, FileLockManager right) {
            return EqualityComparer<FileLockManager>.Default.Equals(left, right);
        }

        /// <summary>Compare two <see cref="PriorityAttribute"/> if they are not equal to each other.</summary>
        /// <param name="left">The first <see cref="PriorityAttribute"/> to check.</param>
        /// <param name="right">The second <see cref="PriorityAttribute"/> to check.</param>
        /// <returns>Compare two <see cref="PriorityAttribute"/> if they are not equal to each other.</returns>
        public static Boolean operator !=(FileLockManager left, FileLockManager right) {
            return !(left == right);
        }
    }
}
