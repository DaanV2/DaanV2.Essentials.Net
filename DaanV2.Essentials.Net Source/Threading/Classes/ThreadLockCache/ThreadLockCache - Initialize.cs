using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Threading {
    ///DOLATER <summary>add description for class: ThreadLockCache</summary>
    public sealed partial class ThreadLockCache<T> {
        /// <summary>Creates a new instance of <see cref="ThreadLockCache"/></summary>
        public ThreadLockCache(ILockPool<T> GlobalPool) {
            this._Pool = GlobalPool;
            this._Locks = new Dictionary<T, LockInstance>();
        }
    }
}
