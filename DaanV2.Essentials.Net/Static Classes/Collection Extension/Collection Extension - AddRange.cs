using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DaanV2 {
    public static partial class CollectionExtension {

        #region Add Array

        /// <summary>Adds the given items onto the collection, from the specified range</summary>
        /// <typeparam name="T">The type of the item that is transfered</typeparam>
        /// <param name="Receiver">The collection that receives the specified items</param>
        /// <param name="values">The source to retrieve the items from</param>
        /// <param name="StartIndex">The start index of where to get items from</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange<T>(this ICollection<T> Receiver, T[] values, Int32 StartIndex) {
            InternalAddRange<ICollection<T>, T[], T>(Receiver, values, StartIndex);
        }

        /// <summary>Adds the given items onto the collection, from the specified range</summary>
        /// <typeparam name="T">The type of the item that is transfered</typeparam>
        /// <param name="Receiver">The collection that receives the specified items</param>
        /// <param name="values">The source to retrieve the items from</param>
        /// <param name="StartIndex">The start index of where to get items from</param>
        /// <param name="Count">The amount of items to add</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange<T>(this ICollection<T> Receiver, T[] values, Int32 StartIndex, Int32 Count) {
            InternalAddRange<ICollection<T>, T[], T>(Receiver, values, StartIndex, Count);
        }

        /// <summary>Adds the given items onto the collection, from the specified range</summary>
        /// <typeparam name="T">The type of the item that is transfered</typeparam>
        /// <param name="Receiver">The collection that receives the specified items</param>
        /// <param name="values">The source to retrieve the items from</param>
        /// <param name="StartIndex">The start index of where to get items from</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange<T>(this List<T> Receiver, T[] values, Int32 StartIndex) {
            AddRange<T[], T>(Receiver, values, StartIndex);
        }

        /// <summary>Adds the given items onto the collection, from the specified range</summary>
        /// <typeparam name="T">The type of the item that is transfered</typeparam>
        /// <param name="Receiver">The collection that receives the specified items</param>
        /// <param name="values">The source to retrieve the items from</param>
        /// <param name="StartIndex">The start index of where to get items from</param>
        /// <param name="Count">The amount of items to add</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange<T>(this List<T> Receiver, T[] values, Int32 StartIndex, Int32 Count) {
            AddRange<T[], T>(Receiver, values, StartIndex, Count);
        }

        #endregion

        #region Add List

        /// <summary>Adds the given items onto the collection, from the specified range</summary>
        /// <typeparam name="T">The type of the item that is transfered</typeparam>
        /// <param name="Receiver">The collection that receives the specified items</param>
        /// <param name="values">The source to retrieve the items from</param>
        /// <param name="StartIndex">The start index of where to get items from</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange<T>(this ICollection<T> Receiver, List<T> values, Int32 StartIndex) {
            InternalAddRange<ICollection<T>, List<T>, T>(Receiver, values, StartIndex);
        }

        /// <summary>Adds the given items onto the collection, from the specified range</summary>
        /// <typeparam name="T">The type of the item that is transfered</typeparam>
        /// <param name="Receiver">The collection that receives the specified items</param>
        /// <param name="values">The source to retrieve the items from</param>
        /// <param name="StartIndex">The start index of where to get items from</param>
        /// <param name="Count">The amount of items to add</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange<T>(this ICollection<T> Receiver, List<T> values, Int32 StartIndex, Int32 Count) {
            InternalAddRange<ICollection<T>, List<T>, T>(Receiver, values, StartIndex, Count);
        }

        /// <summary>Adds the given items onto the collection, from the specified range</summary>
        /// <typeparam name="T">The type of the item that is transfered</typeparam>
        /// <param name="Receiver">The collection that receives the specified items</param>
        /// <param name="values">The source to retrieve the items from</param>
        /// <param name="StartIndex">The start index of where to get items from</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange<T>(this List<T> Receiver, List<T> values, Int32 StartIndex) {
            AddRange<List<T>, T>(Receiver, values, StartIndex);
        }

        /// <summary>Adds the given items onto the collection, from the specified range</summary>
        /// <typeparam name="T">The type of the item that is transfered</typeparam>
        /// <param name="Receiver">The collection that receives the specified items</param>
        /// <param name="values">The source to retrieve the items from</param>
        /// <param name="StartIndex">The start index of where to get items from</param>
        /// <param name="Count">The amount of items to add</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange<T>(this List<T> Receiver, List<T> values, Int32 StartIndex, Int32 Count) {
            AddRange<List<T>, T>(Receiver, values, StartIndex, Count);
        }

        #endregion

        #region Add IList

        /// <summary>Adds the given items onto the collection, from the specified range</summary>
        /// <typeparam name="T">The type of the item that is transfered</typeparam>
        /// <param name="Receiver">The collection that receives the specified items</param>
        /// <param name="values">The source to retrieve the items from</param>
        /// <param name="StartIndex">The start index of where to get items from</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange<T>(this ICollection<T> Receiver, IList<T> values, Int32 StartIndex) {
            InternalAddRange<ICollection<T>, IList<T>, T>(Receiver, values, StartIndex);
        }

        /// <summary>Adds the given items onto the collection, from the specified range</summary>
        /// <typeparam name="T">The type of the item that is transfered</typeparam>
        /// <param name="Receiver">The collection that receives the specified items</param>
        /// <param name="values">The source to retrieve the items from</param>
        /// <param name="StartIndex">The start index of where to get items from</param>
        /// <param name="Count">The amount of items to add</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange<T>(this ICollection<T> Receiver, IList<T> values, Int32 StartIndex, Int32 Count) {
            InternalAddRange<ICollection<T>, IList<T>, T>(Receiver, values, StartIndex, Count);
        }

        /// <summary>Adds the given items onto the collection, from the specified range</summary>
        /// <typeparam name="T">The type of the item that is transfered</typeparam>
        /// <param name="Receiver">The collection that receives the specified items</param>
        /// <param name="values">The source to retrieve the items from</param>
        /// <param name="StartIndex">The start index of where to get items from</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange<T>(this List<T> Receiver, IList<T> values, Int32 StartIndex) {
            AddRange<IList<T>, T>(Receiver, values, StartIndex);
        }

        /// <summary>Adds the given items onto the collection, from the specified range</summary>
        /// <typeparam name="T">The type of the item that is transfered</typeparam>
        /// <param name="Receiver">The collection that receives the specified items</param>
        /// <param name="values">The source to retrieve the items from</param>
        /// <param name="StartIndex">The start index of where to get items from</param>
        /// <param name="Count">The amount of items to add</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange<T>(this List<T> Receiver, IList<T> values, Int32 StartIndex, Int32 Count) {
            AddRange<IList<T>, T>(Receiver, values, StartIndex, Count);
        }

        #endregion

        /// <summary>Adds the given items onto the collection, from the specified range</summary>
        /// <typeparam name="T">The type of collection that receives items</typeparam>
        /// <typeparam name="K">The type of collection that gives item</typeparam>
        /// <typeparam name="V">The type of the item that is transfered</typeparam>
        /// <param name="Receiver">The collection that receives the specified items</param>
        /// <param name="values">The source to retrieve the items from</param>
        /// <param name="StartIndex">The start index of where to get items from</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void InternalAddRange<T, K, V>(T Receiver, K values, Int32 StartIndex)
            where T : ICollection<V>
            where K : IList<V> {

            Int32 Max = values.Count;
            for (Int32 I = StartIndex; I < Max; I++) {
                Receiver.Add(values[I]);
            }
        }

        /// <summary>Adds the given items onto the collection, from the specified range</summary>
        /// <typeparam name="T">The type of collection that receives items</typeparam>
        /// <typeparam name="K">The type of collection that gives item</typeparam>
        /// <typeparam name="V">The type of the item that is transfered</typeparam>
        /// <param name="Receiver">The collection that receives the specified items</param>
        /// <param name="values">The source to retrieve the items from</param>
        /// <param name="StartIndex">The start index of where to get items from</param>
        /// <param name="Count">The amount of items to add</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void InternalAddRange<T, K, V>(T Receiver, K values, Int32 StartIndex, Int32 Count)
            where T : ICollection<V>
            where K : IList<V> {

            Int32 Max = StartIndex + Count;
            for (Int32 I = StartIndex; I < Max; I++) {
                Receiver.Add(values[I]);
            }
        }

        /// <summary>Adds the given items onto the collection, from the specified range</summary>
        /// <typeparam name="K">The type of collection that gives item</typeparam>
        /// <typeparam name="V">The type of the item that is transfered</typeparam>
        /// <param name="Receiver">The collection that receives the specified items</param>
        /// <param name="values">The source to retrieve the items from</param>
        /// <param name="StartIndex">The start index of where to get items from</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange<K, V>(this List<V> Receiver, K values, Int32 StartIndex)
            where K : IList<V> {

            Int32 Max = values.Count;
            Int32 Amount = Max - StartIndex + Receiver.Count;
            if (Receiver.Capacity < Amount) {
                Receiver.Capacity = Amount;
            }

            for (Int32 I = StartIndex; I < Max; I++) {
                Receiver.Add(values[I]);
            }
        }

        /// <summary>Adds the given items onto the collection, from the specified range</summary>
        /// <typeparam name="K">The type of collection that gives item</typeparam>
        /// <typeparam name="V">The type of the item that is transfered</typeparam>
        /// <param name="Receiver">The collection that receives the specified items</param>
        /// <param name="values">The source to retrieve the items from</param>
        /// <param name="StartIndex">The start index of where to get items from</param>
        /// <param name="Count">The amount of items to add</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AddRange<K, V>(this List<V> Receiver, K values, Int32 StartIndex, Int32 Count)
            where K : IList<V> {

            Int32 Amount = Count + Receiver.Count;
            if (Receiver.Capacity < Amount) {
                Receiver.Capacity = Amount;
            }

            Int32 Max = StartIndex + Count;
            for (Int32 I = StartIndex; I < Max; I++) {
                Receiver.Add(values[I]);
            }
        }

    }
}