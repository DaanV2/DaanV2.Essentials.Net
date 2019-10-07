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
        /// <param name="values">FILL_ME_IN</param
        ///DOLATER <returns>Returns a <see cref="FILLIN"/></returns>
        public static List<String> Copy(this List<String> values) {
            List<String> Out = new List<String>(values.Count);
            Int32 Max = values.Count;

            Out.AddRange(values);

            return Out;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values">FILL_ME_IN</param
        ///DOLATER <returns>Returns a <see cref="FILLIN"/></returns>
        public static String[] Copy(this String[] values) {
            String[] Out = new String[values.Length];
            Int32 Max = values.Length;

            for (Int32 I = 0; I < Max; I++) {
                Out[I] = values[I];
            }

            return Out;
        }
    }
}
