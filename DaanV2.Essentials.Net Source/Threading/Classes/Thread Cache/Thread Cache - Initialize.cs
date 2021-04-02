﻿/*ISC License

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
using System.Collections.Concurrent;

namespace DaanV2.Threading {
    /// <summary>A cache to store per thread</summary>
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
