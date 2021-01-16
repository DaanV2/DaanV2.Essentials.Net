using System.Collections.Generic;

namespace DaanV2.Threading {
    public sealed partial class ThreadLockCache<T, U>
        where T : ILockPool<U> {

        /// <summary>
        /// 
        /// </summary>
        private T _Pool;

        /// <summary>
        /// 
        /// </summary>
        private Dictionary<U, LockInstance> _Locks;
    }
}
