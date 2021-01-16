using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DaanV2.Threading {
    public sealed partial class FileLockManager : ILockPool<String> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public EventWaitHandle GetHandle(String Filepath) {
            const Int32 min = 'A';
            Int32 Root = Filepath[0] - min;

            while(Root >= this._RootCount) {
                Root -= this._RootCount;
            }

            if (Root < 0) { Root = 0; }

            return this._DriveLocks[Root].GetHandle(Filepath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public LockInstance GetInstance(String Filepath) {
            return LockInstance.Create(this.GetHandle(Filepath));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public LockInstance GetInstanceWait(String Filepath) {
            return LockInstance.CreateWait(this.GetHandle(Filepath));
        }
    }
}
