using System;
using System.Threading;

namespace DaanV2.Threading {
    public sealed partial class ThreadCache<T> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        public Boolean Set(T Value) {
            return this.Set(Thread.CurrentThread, Value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="thread"></param>
        /// <param name="Value"></param>
        public Boolean Set(Thread thread, T Value) {
            return this._Cache.TryAdd(thread.ManagedThreadId, Value);
        }
    }
}
