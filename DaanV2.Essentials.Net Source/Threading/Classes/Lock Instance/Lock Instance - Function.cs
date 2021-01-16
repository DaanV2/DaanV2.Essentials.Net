using System;

namespace DaanV2.Threading {
    public sealed partial class LockInstance {
        /// <summary>
        /// 
        /// </summary>
        public Boolean Lock() {
            if (!this._Locked) {
                this._Locked = true;
                return this._Lock.WaitOne();
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Boolean UnLock() {
            if (this._Locked) {
                this._Locked = false;
                return this._Lock.Set();
            }

            return false;
        }
    }
}
