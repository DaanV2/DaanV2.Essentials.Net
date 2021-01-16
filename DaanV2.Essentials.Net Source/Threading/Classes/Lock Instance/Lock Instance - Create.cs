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
    public sealed partial class LockInstance {
        /// <summary>Creates a lock but does NOT lock it automaticly, only give this object to 1 thread</summary>
        /// <param name="Lock"></param>
        /// <returns>Creates a instance of the lock that can only be used by 1 thread</returns>
        public static LockInstance Create(EventWaitHandle Lock) {
            return new LockInstance(Lock);
        }

        /// <summary>Creates a lock but does lock it automaticly, only give this object to 1 thread</summary>
        /// <param name="Lock">The lock to wrap around</param>
        /// <returns>Creates a instance of the lock that can only be used by 1 thread</returns>
        public static LockInstance CreateWait(EventWaitHandle Lock) {
            var Out = new LockInstance(Lock);
            Out.Lock();

            return Out;
        }
    }
}
