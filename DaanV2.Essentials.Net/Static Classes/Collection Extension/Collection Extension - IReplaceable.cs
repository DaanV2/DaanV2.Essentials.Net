/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

using System;
using System.Collections.Generic;

namespace DaanV2 {
    public static partial class CollectionExtension {
        /// <summary>Replaces value inside the array.</summary>
        /// <typeparam name="TCollection">The type used for the collection.</typeparam>
        /// <typeparam name="TypeOld">The old type.</typeparam>
        /// <typeparam name="TypeNew">The new type.</typeparam>
        /// <param name="Values">The values to loop through.</param>
        /// <param name="Old">The value to replace.</param>
        /// <param name="New">The value to add into.</param>
        public static void Replace<TCollection, TypeOld, TypeNew>(this TCollection[] Values, TypeOld Old, TypeNew New)
            where TCollection : IReplaceable<TypeOld, TypeNew> {
            Int32 Max = Values.Length;

            for (Int32 I = 0; I < Max; I++) {
                Values[I].Replace(Old, New);
            }
        }

        /// <summary>Replaces value inside the list.</summary>
        /// <typeparam name="TCollection">The type used for the collection.</typeparam>
        /// <typeparam name="TypeOld">The old type.</typeparam>
        /// <typeparam name="TypeNew">The new type.</typeparam>
        /// <param name="Values">The values to loop through.</param>
        /// <param name="Old">The value to replace.</param>
        /// <param name="New">The value to add into.</param>
        public static void Replace<TCollection, TypeOld, TypeNew>(this IList<TCollection> Values, TypeOld Old, TypeNew New)
            where TCollection : IReplaceable<TypeOld, TypeNew> {
            Int32 Max = Values.Count;

            for (Int32 I = 0; I < Max; I++) {
                Values[I].Replace(Old, New);
            }
        }

        /// <summary>Replaces value inside the list.</summary>
        /// <typeparam name="TKey">The type used for the key.</typeparam>
        /// <typeparam name="TCollection">The type used for the collection.</typeparam>
        /// <typeparam name="TypeOld">The old type.</typeparam>
        /// <typeparam name="TypeNew">The new type.</typeparam>
        /// <param name="Values">The values to loop through.</param>
        /// <param name="Old">The value to replace.</param>
        /// <param name="New">The value to add into.</param>
        public static void Replace<TKey, TCollection, TypeOld, TypeNew>(this IDictionary<TKey, TCollection> Values, TypeOld Old, TypeNew New)
            where TCollection : IReplaceable<TypeOld, TypeNew> {

            foreach (KeyValuePair<TKey, TCollection> KVP in Values) {
                KVP.Value.Replace(Old, New);
            }
        }
    }
}