using System;
using System.Threading;

namespace DaanV2.Threading {
    public sealed partial class LockPool {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public EventWaitHandle GetHandle(Int32 Index) {
            if (Index >= this._Count) {
                Index = Index % this._Count;
            }

            return this._Locks[Index];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public EventWaitHandle GetHandle<T>(T O) {
            return this.GetHandle(Index: O.GetHashCode());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public LockInstance GetInstance(Int32 Index) {
            return LockInstance.Create(this.GetHandle(Index));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="O"></param>
        /// <returns></returns>
        public LockInstance GetInstance<T>(T O) {
            return this.GetInstance(Index: O.GetHashCode());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public LockInstance GetInstanceWait(Int32 Index) {
            return LockInstance.CreateWait(this.GetHandle(Index));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="O"></param>
        /// <returns></returns>
        public LockInstance GetInstanceWait<T>(T O) {
            return this.GetInstanceWait(Index: O.GetHashCode());
        }
    }
}
