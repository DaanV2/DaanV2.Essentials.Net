using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DaanV2.Threading {
    ///DOLATER <summary>add description for interface: ILockPool</summary>
    public interface ILockPool<T> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public EventWaitHandle GetHandle(T Index);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public LockInstance GetInstance(T Index);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public LockInstance GetInstanceWait(T Index);
    }
}
