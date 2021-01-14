using System.Threading;

namespace DaanV2.Threading {
    /// <summary>
    /// A class that wraps around a global lock to make a instance,
    /// to be only used for 1 thread, giving thread safety by unlocking on auto, 
    /// is this instance is garbage collected
    /// </summary>
    /// <example>var Lock = LockInstance.CreateWait(Handle);</example>
    public sealed partial class LockInstance {
        /// <summary>Creates a new instance of <see cref="LockInstance"/></summary>
        /// <param name="Lock">The lock to wrap around</param>
        private LockInstance(EventWaitHandle Lock) {
            this._Lock = Lock;
        }

        /// <summary>Disposes of this instance, if still locked then unlock</summary>
        ~LockInstance() {
            this.UnLock();
            this._Lock = null;
        }
    }
}
