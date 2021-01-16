/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.


THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
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
