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
