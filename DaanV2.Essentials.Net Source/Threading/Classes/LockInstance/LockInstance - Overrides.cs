using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DaanV2.Threading {
    public sealed partial class LockInstance : IEquatable<LockInstance> {
        public override Boolean Equals(Object obj) {
            return this.Equals(obj as LockInstance);
        }

        public Boolean Equals(LockInstance other) {
            return other != null &&
                   this._Locked == other._Locked &&
                   EqualityComparer<EventWaitHandle>.Default.Equals(this._Lock, other._Lock);
        }

        public override Int32 GetHashCode() {
            return HashCode.Combine(this._Locked, this._Lock);
        }

        public static Boolean operator ==(LockInstance left, LockInstance right) {
            return EqualityComparer<LockInstance>.Default.Equals(left, right);
        }

        public static Boolean operator !=(LockInstance left, LockInstance right) {
            return !(left == right);
        }
    }
}
