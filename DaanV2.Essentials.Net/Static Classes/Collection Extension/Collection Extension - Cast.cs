using System;
using System.Collections.Generic;

namespace DaanV2 {
    public static partial class CollectionExtension {
        /// <summary>Casts the given array to a list.</summary>
        /// <typeparam name="T">The item type.</typeparam>
        /// <param name="Values">The array to cast.</param>
        /// <returns>Casts the given array to a list.</returns>
        public static List<T> ToList<T>(T[] Values) {
            Int32 Count = Values.Length;
            var Out = new List<T>(Count);

            for (Int32 I = 0; I < Count; I++) {
                Out.Add(Values[I]);
            }

            return Out;
        }

        /// <summary>Casts the given array to a list.</summary>
        /// <typeparam name="T">The item type.</typeparam>
        /// <param name="Values">The array to cast.</param>
        /// <returns>Casts the given array to a list.</returns>
        public static List<T> ToList<T>(IList<T> Values) {
            Int32 Count = Values.Count;
            var Out = new List<T>(Count);

            for (Int32 I = 0; I < Count; I++) {
                Out.Add(Values[I]);
            }

            return Out;
        }
    }
}