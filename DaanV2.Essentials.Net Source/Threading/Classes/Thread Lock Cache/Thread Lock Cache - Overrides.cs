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
    public sealed partial class ThreadLockCache<T, U> : IEquatable<ThreadLockCache<T, U>> 
        where T : ILockPool<U> {
        /// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
        /// <param name="obj">The object to check against.</param>
        /// <returns>Returns a value that indicates whether this instance is equal to a specified object.</returns>
        public override Boolean Equals(Object obj) {
            return this.Equals(obj as ThreadLockCache<T, U>);
        }

        /// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
        /// <param name="other">The object to check against.</param>
        /// <returns>Returns a value that indicates whether this instance is equal to a specified object.</returns>
        public Boolean Equals(ThreadLockCache<T, U> other) {
            return other != null &&
                   EqualityComparer<T>.Default.Equals(this._Pool, other._Pool) &&
                   EqualityComparer<Dictionary<U, LockInstance>>.Default.Equals(this._Locks, other._Locks);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>Returns the hash code for this instance.</returns>
        public override Int32 GetHashCode() {
#if NETCORE
            return HashCode.Combine(this._Pool, this._Locks);
#else
            Int32 hashCode = -481962414;
            hashCode = hashCode * -1521134295 + EqualityComparer<T>.Default.GetHashCode(this._Pool);
            hashCode = hashCode * -1521134295 + EqualityComparer<Dictionary<U, LockInstance>>.Default.GetHashCode(this._Locks);
            return hashCode;
#endif
        }

        /// <summary>Compare two <see cref="PriorityAttribute"/> if they are equal to each other.</summary>
        /// <param name="left">The first <see cref="PriorityAttribute"/> to check.</param>
        /// <param name="right">The second <see cref="PriorityAttribute"/> to check.</param>
        /// <returns>Compare two <see cref="PriorityAttribute"/> if they are equal to each other.</returns>
        public static Boolean operator ==(ThreadLockCache<T, U> left, ThreadLockCache<T, U> right) {
            return EqualityComparer<ThreadLockCache<T, U>>.Default.Equals(left, right);
        }

        /// <summary>Compare two <see cref="PriorityAttribute"/> if they are not equal to each other.</summary>
        /// <param name="left">The first <see cref="PriorityAttribute"/> to check.</param>
        /// <param name="right">The second <see cref="PriorityAttribute"/> to check.</param>
        /// <returns>Compare two <see cref="PriorityAttribute"/> if they are not equal to each other.</returns>
        public static Boolean operator !=(ThreadLockCache<T, U> left, ThreadLockCache<T, U> right) {
            return !(left == right);
        }
    }
}
