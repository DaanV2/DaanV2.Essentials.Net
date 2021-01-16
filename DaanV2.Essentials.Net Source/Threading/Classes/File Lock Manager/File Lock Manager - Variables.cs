using System;

namespace DaanV2.Threading {
    public sealed partial class FileLockManager {
        /// <summary></summary>
        private LockPool[] _DriveLocks;

        /// <summary></summary>
        private Int32 _RootCount;

        /// <summary></summary>
        private Int32 _LockPerRootCount;
    }
}
