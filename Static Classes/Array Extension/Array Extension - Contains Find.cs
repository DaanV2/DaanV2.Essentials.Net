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

namespace DaanV2 {
    public static partial class ArrayExtension {

        ///DOLATER <summary>Add Description</summary>
        /// <typeparam name="Type"></typeparam>
        /// <param name="Array"></param>
        /// <param name="Find"></param>
        /// <returns></returns>
        public static Boolean Contains<Type>(this Type[] Array, Type Find) {

            for (Int32 I = 0; I < Array.Length; I++) {
                if (Array[I].Equals(Find))
                    return true;
            }

            return false;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <typeparam name="Type"></typeparam>
        /// <param name="Array"></param>
        /// <param name="Find"></param>
        /// <param name="StartIndex"></param>
        /// <returns></returns>
        public static Int32 Find<Type>(this Type[] Array, Type Find, Int32 StartIndex = 0) {

            for (Int32 I = 0; I < Array.Length; I++) {
                if (Array[I].Equals(Find))
                    return I;
            }

            return -1;
        }
    }
}
