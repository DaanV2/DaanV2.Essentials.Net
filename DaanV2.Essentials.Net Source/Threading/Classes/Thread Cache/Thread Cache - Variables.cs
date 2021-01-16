using System;
using System.Collections.Concurrent;

namespace DaanV2.Threading {
    public sealed partial class ThreadCache<T> {
        /// <summary></summary>
        private ConcurrentDictionary<Int32, T> _Cache;

        /// <summary>
        /// 
        /// </summary>
        private Func<Int32, T> _ValueFactory;
    }
}
