using System;
using System.Collections.Generic;

namespace DaanV2.Threading {
    public sealed partial class ThreadLockCache<T> : IEquatable<ThreadLockCache<T>> {
        public override Boolean Equals(Object obj) {
            return this.Equals(obj as ThreadLockCache<T>);
        }

        public Boolean Equals(ThreadLockCache<T> other) {
            return other != null &&
                   EqualityComparer<ILockPool<T>>.Default.Equals(this._Pool, other._Pool) &&
                   EqualityComparer<Dictionary<T, LockInstance>>.Default.Equals(this._Locks, other._Locks);
        }

        public override Int32 GetHashCode() {
            return HashCode.Combine(this._Pool, this._Locks);
        }

        public static Boolean operator ==(ThreadLockCache<T> left, ThreadLockCache<T> right) {
            return EqualityComparer<ThreadLockCache<T>>.Default.Equals(left, right);
        }

        public static Boolean operator !=(ThreadLockCache<T> left, ThreadLockCache<T> right) {
            return !(left == right);
        }
    }
}
