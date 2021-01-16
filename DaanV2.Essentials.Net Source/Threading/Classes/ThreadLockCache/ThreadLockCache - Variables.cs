using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Threading {
    public sealed partial class ThreadLockCache<T> {
        private ILockPool<T> _Pool;
        private Dictionary<T, LockInstance> _Locks;
    }
}
