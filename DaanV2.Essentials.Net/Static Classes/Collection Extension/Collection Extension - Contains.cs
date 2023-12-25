using System;
using System.Collections.Generic;

namespace DaanV2 {
    public static partial class CollectionExtension {
        /// <summary>Checks if an array contains the specified object.</summary>
        /// <typeparam name="T">The type of object the array exists of.</typeparam>
        /// <param name="Collection">The collection to search through.</param>
        /// <param name="Value">The value to find.</param>
        /// <returns>Checks if an array contains the specified object.</returns>
        public static Boolean Contains<T>(this T[] Collection, T Value) {
            Int32 Max = Collection.Length;

            if (Value is null) {
                //Find a null item
                for (Int32 I = 0; I < Max; I++) {
                    if (Collection[I] is null) {
                        return true;
                    }
                }
            }
            //Value is not null
            else {
                for (Int32 I = 0; I < Max; I++) {
                    if (Value.Equals(Collection[I])) {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>Checks if an list contains the specified object.</summary>
        /// <typeparam name="T">The type of object the array exists of.</typeparam>
        /// <param name="Collection">The collection to search through.</param>
        /// <param name="Value">The value to find.</param>
        /// <returns>Checks if an list contains the specified object.</returns>
        public static Boolean Contains<T>(this IList<T> Collection, T Value) {
            Int32 Max = Collection.Count;

            if (Value is null) {
                //Find a null item
                for (Int32 I = 0; I < Max; I++) {
                    if (Collection[I] is null) {
                        return true;
                    }
                }
            }
            //Value is not null
            else {
                for (Int32 I = 0; I < Max; I++) {
                    if (Value.Equals(Collection[I])) {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}