using System;
using System.Threading;

namespace DaanV2.Threading {
    public sealed partial class ThreadCache<T> {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public T GetCache() {
            return this.GetCache(Thread.CurrentThread);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ValueFactory"></param>
        /// <returns></returns>
        public T GetCache(Func<Int32, T> ValueFactory) {
            return this.GetCache(Thread.CurrentThread, ValueFactory);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public T GetCache(Thread thread) {
        
            Int32 ID = thread.ManagedThreadId;

            if (this._ValueFactory == null) {
                if (this._Cache.TryGetValue(ID, out T value)) {
                    return value;
                }

                return default;
            }


            return this._Cache.GetOrAdd(ID, this._ValueFactory);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ValueFactory"></param>
        /// <returns></returns>
        public T GetCache(Thread thread, Func<Int32, T> ValueFactory) {
            Int32 ID = thread.ManagedThreadId;

            return this._Cache.GetOrAdd(ID, ValueFactory);
        }
    }
}
