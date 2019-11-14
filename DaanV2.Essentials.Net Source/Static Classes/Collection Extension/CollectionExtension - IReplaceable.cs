/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.


THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS.IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/

using System;
using System.Collections.Generic;

namespace DaanV2 {
    public static partial class CollectionExtension {

        ///DOLATER <summary>Add Description</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Params">FILL_ME_IN</param>
        /// <param name="Old">FILL_ME_IN</param>
        /// <param name="New">FILL_ME_IN</param>
        public static void Replace<TCollection, TypeOld, TypeNew>(this TCollection[] Values, TypeOld Old, TypeNew New)
            where TCollection : IReplaceable<TypeOld, TypeNew> {
            Int32 Max = Values.Length;

            for (Int32 I = 0; I < Max; I++) {
                Values[I].Replace(Old, New);
            }
        }

        ///DOLATER <summary>Add Description</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Values">FILL_ME_IN</param>
        /// <param name="Old">FILL_ME_IN</param>
        /// <param name="New">FILL_ME_IN</param>
        public static void Replace<TCollection, TypeOld, TypeNew>(this List<TCollection> Values, TypeOld Old, TypeNew New)
            where TCollection : IReplaceable<TypeOld, TypeNew> {
            Int32 Max = Values.Count;

            for (Int32 I = 0; I < Max; I++) {
                Values[I].Replace(Old, New);
            }
        }
    }
}
