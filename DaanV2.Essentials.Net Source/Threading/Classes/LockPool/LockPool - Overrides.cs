using System;
using System.Collections.Generic;
using System.Threading;

namespace DaanV2.Threading {
    public sealed partial class LockPool : IEquatable<LockPool> {
        public override Boolean Equals(Object obj) {
            return this.Equals(obj as LockPool);
        }

        public Boolean Equals(LockPool other) {
            return other != null &&
                   EqualityComparer<EventWaitHandle[]>.Default.Equals(this._Locks, other._Locks) &&
                   this._Count == other._Count;
        }

        public override Int32 GetHashCode() {
            return HashCode.Combine(this._Locks, this._Count);
        }

        public static Boolean operator ==(LockPool left, LockPool right) {
            return EqualityComparer<LockPool>.Default.Equals(left, right);
        }

        public static Boolean operator !=(LockPool left, LockPool right) {
            return !(left == right);
        }
    }
}
