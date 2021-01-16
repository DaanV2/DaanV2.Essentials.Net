using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DaanV2.Threading {
    public sealed partial class LockInstance : IEquatable<LockInstance> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj) {
            return this.Equals(obj as LockInstance);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(LockInstance other) {
            return other != null &&
                   this._Locked == other._Locked &&
                   EqualityComparer<EventWaitHandle>.Default.Equals(this._Lock, other._Lock);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Int32 GetHashCode() {
            return HashCode.Combine(this._Locked, this._Lock);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator ==(LockInstance left, LockInstance right) {
            return EqualityComparer<LockInstance>.Default.Equals(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator !=(LockInstance left, LockInstance right) {
            return !(left == right);
        }
    }
}
