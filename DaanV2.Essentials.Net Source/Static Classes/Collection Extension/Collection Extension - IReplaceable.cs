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


        /// <summary>Replaces value inside the array</summary>
        /// <typeparam name="TCollection"></typeparam>
        /// <typeparam name="TypeOld"></typeparam>
        /// <typeparam name="TypeNew"></typeparam>
        /// <param name="Values">The values to loop through</param>
        /// <param name="Old">The value to replace</param>
        /// <param name="New">The value to add into</param>
        public static void Replace<TCollection, TypeOld, TypeNew>(this TCollection[] Values, TypeOld Old, TypeNew New)
            where TCollection : IReplaceable<TypeOld, TypeNew> {
            Int32 Max = Values.Length;

            for (Int32 I = 0; I < Max; I++) {
                Values[I].Replace(Old, New);
            }
        }

        /// <summary>Replaces value inside the list</summary>
        /// <typeparam name="TCollection"></typeparam>
        /// <typeparam name="TypeOld"></typeparam>
        /// <typeparam name="TypeNew"></typeparam>
        /// <param name="Values">The values to loop through</param>
        /// <param name="Old">The value to replace</param>
        /// <param name="New">The value to add into</param>
        public static void Replace<TCollection, TypeOld, TypeNew>(this IList<TCollection> Values, TypeOld Old, TypeNew New)
            where TCollection : IReplaceable<TypeOld, TypeNew> {
            Int32 Max = Values.Count;

            for (Int32 I = 0; I < Max; I++) {
                Values[I].Replace(Old, New);
            }
        }
    }
}
