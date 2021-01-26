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
using System.Threading;

namespace DaanV2.Threading {
    /// <summary>The static class that extends <see cref="ILockPool{T}"/></summary>
    public static partial class LookPoolExtension {
        /// <summary>Returns the <see cref="EventWaitHandle"/> that is associated to the given key</summary>
        /// <typeparam name="U">The object to calculate a hashcode of and uses it as a key</typeparam>
        /// <param name="Pool">The pool to retrieve from</param>
        /// <param name="value">The key to be used</param>
        /// <returns>The  <see cref="EventWaitHandle"/> that is associated to the given key</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EventWaitHandle GetHandle<U>(this ILockPool<Int32> Pool, U value) {
            Int32 HashCode = value.GetHashCode();

            if (HashCode < 0) {
                HashCode *= -1;
            }

            return Pool.GetHandle(HashCode);
        }

        /// <summary>Returns the <see cref="EventWaitHandle"/> that is associated to the given key</summary>
        /// <param name="Pool">The pool to retrieve from</param>
        /// <param name="value">The key to be used</param>
        /// <returns>The  <see cref="EventWaitHandle"/> that is associated to the given key</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EventWaitHandle GetHandle(this ILockPool<Int32> Pool, String value) {
            return GetHandle<String>(Pool, value);
        }
    }
}
