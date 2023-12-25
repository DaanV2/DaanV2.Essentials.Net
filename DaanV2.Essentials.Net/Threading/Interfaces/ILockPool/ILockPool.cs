using System.Threading;

namespace DaanV2.Threading {
    ///DOLATER <summary>add description for interface: ILockPool</summary>
    public interface ILockPool<T> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        EventWaitHandle GetHandle(T Index);
    }
}