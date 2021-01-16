using System;
using System.Collections.Concurrent;

namespace DaanV2.Threading {
    ///DOLATER <summary>add description for class: ThreadCache</summary>
    public sealed partial class ThreadCache<T> {
        /// <summary>Creates a new instance of <see cref="ThreadCache{T}"/></summary>
        public ThreadCache() {
            this._Cache = new ConcurrentDictionary<Int32, T>(Environment.ProcessorCount, Environment.ProcessorCount * 8);
            this._ValueFactory = null;
        }

        /// <summary>Creates a new instance of <see cref="ThreadCache{T}"/></summary>
        /// <param name="ConcurrencyLevel"></param>
        /// <param name="Capacity"></param>
        public ThreadCache(Int32 ConcurrencyLevel, Int32 Capacity) {
            this._Cache = new ConcurrentDictionary<Int32, T>(ConcurrencyLevel, Capacity);
            this._ValueFactory = null;
        }

        /// <summary>Creates a new instance of <see cref="ThreadCache{T}"/></summary>
        public ThreadCache(Func<Int32, T> ValueFactory) {
            this._Cache = new ConcurrentDictionary<Int32, T>(Environment.ProcessorCount, Environment.ProcessorCount * 8);
            this._ValueFactory = ValueFactory;
        }

        /// <summary>Creates a new instance of <see cref="ThreadCache{T}"/></summary>
        /// <param name="ConcurrencyLevel"></param>
        /// <param name="Capacity"></param>
        public ThreadCache(Func<Int32, T> ValueFactory, Int32 ConcurrencyLevel, Int32 Capacity) {
            this._Cache = new ConcurrentDictionary<Int32, T>(ConcurrencyLevel, Capacity);
            this._ValueFactory = ValueFactory;
        }
    }
}
