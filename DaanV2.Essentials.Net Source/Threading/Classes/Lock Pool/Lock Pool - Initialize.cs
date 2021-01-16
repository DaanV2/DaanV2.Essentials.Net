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
    /// <summary>A pool of event wait handle for global use</summary>
    public sealed partial class LockPool {
        /// <summary>Creates a new instance of <see cref="LockPool"/></summary>
        /// <param name="LockCount"></param>
        /// <param name="initialState"></param>
        /// <param name="mode"></param>
        public LockPool(Int32 LockCount, Boolean initialState = true, EventResetMode mode = EventResetMode.AutoReset) {
            this._Count = LockCount;
            this._Locks = new EventWaitHandle[LockCount];

            for (Int32 I = 0; I < this._Locks.Length; I++) {
                this._Locks[I] = new EventWaitHandle(initialState, mode);
            }
        }
    }
}
