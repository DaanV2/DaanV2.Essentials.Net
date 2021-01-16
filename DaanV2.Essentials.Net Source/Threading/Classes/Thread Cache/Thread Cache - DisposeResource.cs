using System;
using System.Threading;

namespace DaanV2.Threading {
    public sealed partial class ThreadCache<T> {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Boolean DisposeThreadResource() {
            return this.DisposeThreadResource(Thread.CurrentThread);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Thread"></param>
        /// <returns></returns>
        public Boolean DisposeThreadResource(Thread Thread) {
            return this._Cache.TryRemove(Thread.ManagedThreadId, out T _);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Boolean DisposeThreadResource(out T Value) {
            Boolean Out = this.DisposeThreadResource(Thread.CurrentThread, out T Temp);
            Value = Temp;

            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Thread"></param>
        /// <returns></returns>
        public Boolean DisposeThreadResource(Thread Thread, out T Value) {
            Boolean Out = this._Cache.TryRemove(Thread.ManagedThreadId, out T Temp);
            Value = Temp;

            return Out;
        }
    }
}
