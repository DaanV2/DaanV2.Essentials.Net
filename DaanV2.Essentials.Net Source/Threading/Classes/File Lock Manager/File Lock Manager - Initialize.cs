using System;
using System.IO;

namespace DaanV2.Threading {
    ///DOLATER <summary>add description for class: FileLockManager</summary>
    public sealed partial class FileLockManager {
        /// <summary>Creates a new instance of <see cref="FileLockManager"/></summary>
        /// <param name="LockPerRoot"></param>
        public FileLockManager(Int32 LockPerRoot) {
            this.CreateLocks(DriveInfo.GetDrives().Length, LockPerRoot);
        }

        /// <summary>Creates a new instance of <see cref="FileLockManager"/></summary>
        /// <param name="RootCount"></param>
        /// <param name="LockPerRoot"></param>
        public FileLockManager(Int32 RootCount, Int32 LockPerRoot) {
            this.CreateLocks(RootCount, LockPerRoot);
        }

        /// <summary>Creates a new instance of <see cref="FileLockManager"/></summary>
        /// <param name="RootCount"></param>
        /// <param name="LockPerRoot"></param>
        private void CreateLocks(Int32 RootCount, Int32 LockPerRoot) {
            if (RootCount < 1) {
                RootCount = 3;
            }

            if (LockPerRoot < 1) {
                LockPerRoot = 3;
            }

            this._RootCount = RootCount;
            this._LockPerRootCount = LockPerRoot;

            this._DriveLocks = new LockPool[RootCount];

            for (Int32 I = 0; I < RootCount; I++) {
                this._DriveLocks[I] = new LockPool(RootCount);
            }
        }
    }
}
