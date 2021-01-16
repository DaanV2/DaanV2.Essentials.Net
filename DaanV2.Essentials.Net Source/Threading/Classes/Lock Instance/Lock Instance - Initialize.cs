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
using System.Threading;

namespace DaanV2.Threading {
    /// <summary>
    /// A class that wraps around a global lock to make a instance,
    /// to be only used for 1 thread, giving thread safety by unlocking on auto, 
    /// is this instance is garbage collected
    /// </summary>
    /// <example>var Lock = LockInstance.CreateWait(Handle);</example>
    public sealed partial class LockInstance {
        /// <summary>Creates a new instance of <see cref="LockInstance"/></summary>
        /// <param name="Lock">The lock to wrap around</param>
        private LockInstance(EventWaitHandle Lock) {
            this._Lock = Lock;
        }

        /// <summary>Disposes of this instance, if still locked then unlock</summary>
        ~LockInstance() {
            this.UnLock();
            this._Lock = null;
        }
    }
}
