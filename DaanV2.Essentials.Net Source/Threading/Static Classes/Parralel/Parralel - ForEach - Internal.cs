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
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DaanV2.Threading {
    public static partial class Parallel {
        /// <summary>The internal method used for the foreach loop.</summary>
        /// <typeparam name="T">The object to process.</typeparam>
        /// <param name="Context">The context needed to process.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void ForEachInternal<T>(ParallelContext<T> Context) {
            Int32 StartIndex = Context._StartIndex;
            Int32 EndIndex = Context._EndIndex;
            T[] Items = Context._Items;
            Action<T> Action = Context._Action;

            for (Int32 I = StartIndex; I < EndIndex; I++) {
                Action.Invoke(Items[I]);
            }
        }

        /// <summary>The internal method used for the foreach loop.</summary>
        /// <typeparam name="T">The object to process.</typeparam>
        /// <typeparam name="T1">The additional type to process.</typeparam>
        /// <param name="Context">The context needed to process.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void ForEachInternal<T, T1>(ParallelContext<T, T1> Context) {
            Int32 StartIndex = Context._StartIndex;
            Int32 EndIndex = Context._EndIndex;
            T[] Items = Context._Items;
            Action<T, T1> Action = Context._Action;
            T1 Argument1 = Context._Argument1;

            for (Int32 I = StartIndex; I < EndIndex; I++) {
                Action.Invoke(Items[I], Argument1);
            }
        }

        /// <summary>The internal method used for the foreach loop.</summary>
        /// <typeparam name="T">The object to process.</typeparam>
        /// <param name="Context">The context needed to process.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void ForEachInternal<T>(ParallelContextCollection<T> Context) {
            Int32 StartIndex = Context._StartIndex;
            Int32 EndIndex = Context._EndIndex;
            IList<T> Items = Context._Items;
            Action<T> Action = Context._Action;

            for (Int32 I = StartIndex; I < EndIndex; I++) {
                Action.Invoke(Items[I]);
            }
        }

        /// <summary>The internal method used for the foreach loop.</summary>
        /// <typeparam name="T">The object to process.</typeparam>
        /// <typeparam name="T1">The additional type to process.</typeparam>
        /// <param name="Context">The context needed to process.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void ForEachInternal<T, T1>(ParallelContextCollection<T, T1> Context) {
            Int32 StartIndex = Context._StartIndex;
            Int32 EndIndex = Context._EndIndex;
            IList<T> Items = Context._Items;
            Action<T, T1> Action = Context._Action;
            T1 Argument1 = Context._Argument1;

            for (Int32 I = StartIndex; I < EndIndex; I++) {
                Action.Invoke(Items[I], Argument1);
            }
        }
    }
}
