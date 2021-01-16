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
using System.Runtime.CompilerServices;

namespace DaanV2.Threading {
    public static partial class LookPoolExtension {
        /// <summary>Gets a lock instance/summary>
        /// <typeparam name="T">The sub type of pools</typeparam>
        /// <param name="Pool">The pool to retrieve the handle from</param>
        /// <param name="Index">The key associated to the handle</param>
        /// <returns>A <see cref="LockInstance"/> that is not locked</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LockInstance GetInstance<T>(this ILockPool<T> Pool, T Index) {
            return LockInstance.Create(Pool.GetHandle(Index));
        }

        /// <summary>Gets a lock instance/summary>
        /// <typeparam name="T">The sub type of pools</typeparam>
        /// <param name="Pool">The pool to retrieve the handle from</param>
        /// <param name="Index">The key associated to the handle</param>
        /// <returns>A <see cref="LockInstance"/> that is locked</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LockInstance GetInstanceWait<T>(this ILockPool<T> Pool, T Index) {
            return LockInstance.CreateWait(Pool.GetHandle(Index));
        }

        /// <summary>Gets a lock instance/summary>
        /// <typeparam name="T">The sub type of pools</typeparam>
        /// <param name="Pool">The pool to retrieve the handle from</param>
        /// <param name="Index">The key associated to the handle</param>
        /// <returns>A <see cref="LockInstance"/> that is not locked</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LockInstance GetInstance(this ILockPool<Int32> Pool, String Index) {
            return LockInstance.Create(Pool.GetHandle(Index));
        }

        /// <summary>Gets a lock instance/summary>
        /// <typeparam name="T">The sub type of pools</typeparam>
        /// <param name="Pool">The pool to retrieve the handle from</param>
        /// <param name="Index">The key associated to the handle</param>
        /// <returns>A <see cref="LockInstance"/> that is locked</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LockInstance GetInstanceWait<T>(this ILockPool<Int32> Pool, String Index) {
            return LockInstance.CreateWait(Pool.GetHandle(Index));
        }
    }
}
