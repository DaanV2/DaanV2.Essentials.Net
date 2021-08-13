/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DaanV2.Threading {
    public static partial class Parallel {
        public static partial class Func {
            /// <summary>The internal method used for the foreach loop.</summary>
            /// <typeparam name="T">The object to process.</typeparam>
            /// <typeparam name="U">The output of the func</typeparam>
            /// <param name="Context">The context needed to process.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static void ForEachInternal<T, U>(ParallelFuncContext<T, U> Context) {
                Int32 StartIndex = Context._StartIndex;
                Int32 EndIndex = Context._EndIndex;
                T[] Items = Context._Items;
                Func<T, U> Action = Context._Action;
                U[] Receiver = Context._Receiver;

                for (Int32 I = StartIndex; I < EndIndex; I++) {
                    Receiver[I] = Action.Invoke(Items[I]);
                }
            }

            /// <summary>The internal method used for the foreach loop.</summary>
            /// <typeparam name="T">The object to process.</typeparam>
            /// <typeparam name="T1">The additional type to process.</typeparam>
            /// <typeparam name="U">The output of the func</typeparam>
            /// <param name="Context">The context needed to process.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static void ForEachInternal<T, T1, U>(ParallelFuncContext<T, T1, U> Context) {
                Int32 StartIndex = Context._StartIndex;
                Int32 EndIndex = Context._EndIndex;
                T[] Items = Context._Items;
                Func<T, T1, U> Action = Context._Action;
                T1 Argument1 = Context._Argument1;
                U[] Receiver = Context._Receiver;

                for (Int32 I = StartIndex; I < EndIndex; I++) {
                    Receiver[I] = Action.Invoke(Items[I], Argument1);
                }
            }

            /// <summary>The internal method used for the foreach loop.</summary>
            /// <typeparam name="T">The object to process.</typeparam>
            /// <typeparam name="U">The output of the func</typeparam>
            /// <param name="Context">The context needed to process.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static void ForEachInternal<T, U>(ParallelFuncContextCollection<T, U> Context) {
                Int32 StartIndex = Context._StartIndex;
                Int32 EndIndex = Context._EndIndex;
                IList<T> Items = Context._Items;
                Func<T, U> Action = Context._Action;
                U[] Receiver = Context._Receiver;

                for (Int32 I = StartIndex; I < EndIndex; I++) {
                    Receiver[I] = Action.Invoke(Items[I]);
                }
            }

            /// <summary>The internal method used for the foreach loop.</summary>
            /// <typeparam name="T">The object to process.</typeparam>
            /// <typeparam name="T1">The additional type to process.</typeparam>
            /// <typeparam name="U">The output of the func</typeparam>
            /// <param name="Context">The context needed to process.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static void ForEachInternal<T, T1, U>(ParallelFuncContextCollection<T, T1, U> Context) {
                Int32 StartIndex = Context._StartIndex;
                Int32 EndIndex = Context._EndIndex;
                IList<T> Items = Context._Items;
                T1 Argument1 = Context._Argument1;
                Func<T, T1, U> Action = Context._Action;
                U[] Receiver = Context._Receiver;

                for (Int32 I = StartIndex; I < EndIndex; I++) {
                    Receiver[I] = Action.Invoke(Items[I], Argument1);
                }
            }
        }
    }
}
