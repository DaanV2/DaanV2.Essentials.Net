using System;
using System.Threading;

namespace DaanV2.Threading {
    /// <summary>A pool of event wait handle for global use</summary>
    public sealed partial class LockPool {
        /// <summary>Creates a new instance of <see cref="LockPool"/></summary>
        /// <param name="LockCount"></param>
        /// <param name="initialState"></param>
        /// <param name="mode"></param>
        public LockPool(Int32 LockCount, Boolean initialState = true, EventResetMode mode = EventResetMode.AutoReset) {
            this._Count = LockCount;
            this._Locks = new EventWaitHandle[LockCount];

            for (Int32 I = 0; I < this._Locks.Length; I++) {
                this._Locks[I] = new EventWaitHandle(initialState, mode);
            }
        }
    }
}
