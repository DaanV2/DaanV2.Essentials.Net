/*ISC License

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
using System.Threading;

namespace DaanV2.Threading {
    public sealed partial class LockInstance : IEquatable<LockInstance> {
        /// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
        /// <param name="obj">The object to check against.</param>
        /// <returns>Returns a value that indicates whether this instance is equal to a specified object.</returns>
        public override Boolean Equals(Object obj) {
            return this.Equals(obj as LockInstance);
        }

        /// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
        /// <param name="other">The object to check against.</param>
        /// <returns>Returns a value that indicates whether this instance is equal to a specified object.</returns>
        public Boolean Equals(LockInstance other) {
            return other != null &&
                   this._Locked == other._Locked &&
                   EqualityComparer<EventWaitHandle>.Default.Equals(this._Lock, other._Lock);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>Returns the hash code for this instance.</returns>
        public override Int32 GetHashCode() {
#if NETCORE
            return HashCode.Combine(this._Locked, this._Lock);
#else
            Int32 hashCode = 1866263273;
            hashCode = hashCode * -1521134295 + this._Locked.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<EventWaitHandle>.Default.GetHashCode(this._Lock);
            return hashCode;
#endif
        }

        /// <summary>Compare two <see cref="PriorityAttribute"/> if they are equal to each other.</summary>
        /// <param name="left">The first <see cref="PriorityAttribute"/> to check.</param>
        /// <param name="right">The second <see cref="PriorityAttribute"/> to check.</param>
        /// <returns>Compare two <see cref="PriorityAttribute"/> if they are equal to each other.</returns>
        public static Boolean operator ==(LockInstance left, LockInstance right) {
            return EqualityComparer<LockInstance>.Default.Equals(left, right);
        }

        /// <summary>Compare two <see cref="PriorityAttribute"/> if they are not equal to each other.</summary>
        /// <param name="left">The first <see cref="PriorityAttribute"/> to check.</param>
        /// <param name="right">The second <see cref="PriorityAttribute"/> to check.</param>
        /// <returns>Compare two <see cref="PriorityAttribute"/> if they are not equal to each other.</returns>
        public static Boolean operator !=(LockInstance left, LockInstance right) {
            return !(left == right);
        }
    }
}
