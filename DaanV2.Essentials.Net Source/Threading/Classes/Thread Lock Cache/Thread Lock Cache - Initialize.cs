using System.Collections.Generic;

namespace DaanV2.Threading {
    ///DOLATER <summary>add description for class: <see cref="ThreadLockCache{T}"/></summary>
    public sealed partial class ThreadLockCache<T,  U>
        where T : ILockPool<U> {
        /// <summary>Creates a new instance of <see cref="ThreadLockCache{T}"/></summary>
        /// <param name="GlobalPool"></param>
        public ThreadLockCache(T GlobalPool) {
            this._Pool = GlobalPool;
            this._Locks = new Dictionary<U, LockInstance>();
        }
    }
}
