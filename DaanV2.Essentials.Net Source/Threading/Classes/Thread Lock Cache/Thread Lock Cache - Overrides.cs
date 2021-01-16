using System;
using System.Collections.Generic;

namespace DaanV2.Threading {
    public sealed partial class ThreadLockCache<T, U> : IEquatable<ThreadLockCache<T, U>> 
        where T : ILockPool<U> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj) {
            return this.Equals(obj as ThreadLockCache<T, U>);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(ThreadLockCache<T, U> other) {
            return other != null &&
                   EqualityComparer<T>.Default.Equals(this._Pool, other._Pool) &&
                   EqualityComparer<Dictionary<U, LockInstance>>.Default.Equals(this._Locks, other._Locks);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Int32 GetHashCode() {
            return HashCode.Combine(this._Pool, this._Locks);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator ==(ThreadLockCache<T, U> left, ThreadLockCache<T, U> right) {
            return EqualityComparer<ThreadLockCache<T, U>>.Default.Equals(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator !=(ThreadLockCache<T, U> left, ThreadLockCache<T, U> right) {
            return !(left == right);
        }
    }
}
