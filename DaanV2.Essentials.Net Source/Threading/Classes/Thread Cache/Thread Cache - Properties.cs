using System;
using System.Collections.Concurrent;

namespace DaanV2.Threading {
    public sealed partial class ThreadCache<T> {
        /// <summary>
        /// 
        /// </summary>
        public ConcurrentDictionary<Int32, T> Cache => this._Cache;
    }
}
