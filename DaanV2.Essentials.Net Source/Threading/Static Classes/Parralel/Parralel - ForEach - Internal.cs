﻿/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
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
