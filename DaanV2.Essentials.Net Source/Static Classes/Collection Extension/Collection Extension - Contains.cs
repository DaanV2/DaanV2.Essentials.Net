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

namespace DaanV2 {
    public static partial class CollectionExtension {
        /// <summary>Checks if an array contains the specified object.</summary>
        /// <typeparam name="T">The type of object the array exists of.</typeparam>
        /// <param name="Collection">The collection to search through.</param>
        /// <param name="Value">The value to find.</param>
        /// <returns>Checks if an array contains the specified object.</returns>
        public static Boolean Contains<T>(this T[] Collection, T Value) {
            Int32 Max = Collection.Length;

            if (Value == null){
                //Find a null item
                for (Int32 I = 0; I < Max; I++) {
                    if (Collection[I] == null) {
                        return true;
                    }
                }
            }
            //Value is not null
            else{
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

            if (Value == null){
                //Find a null item
                for (Int32 I = 0; I < Max; I++) {
                    if (Collection[I] == null) {
                        return true;
                    }
                }
            }
            //Value is not null
            else{
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
