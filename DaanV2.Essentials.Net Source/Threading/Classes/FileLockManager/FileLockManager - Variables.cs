using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Threading {
    public sealed partial class FileLockManager {
        private LockPool[] _DriveLocks;
        private Int32 _RootCount;
        private Int32 _LockPerRootCount;
    }
}
