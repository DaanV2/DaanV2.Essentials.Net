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
using System.Reflection;

namespace DaanV2 {
    public static partial class TypeExtension {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Contains"></param>
        /// <returns></returns>
        public static List<Object> GetObjectsWhichImplements(Type Contains) {
            List<Type> Types = GetTypesWhichImplements(Contains);
            List<Object> Objects = new List<Object>(Types.Count);
            Int32 Length = Types.Count;

            for (Int32 I = 0; I < Length; I++) {
                Objects[I] = Activator.CreateInstance(Types[I]);
            }

            return Objects;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Contains"></param>
        /// <returns></returns>
        public static List<T> GetObjectsWhichImplements<T>() {
            List<Type> Types = GetTypesWhichImplements(typeof(T));
            List<T> Objects = new List<T>(Types.Count);
            Int32 Length = Types.Count;

            for (Int32 I = 0; I < Length; I++) {
                Objects[I] = (T)Activator.CreateInstance(Types[I]);
            }

            return Objects;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Contains"></param>
        /// <returns></returns>
        public static List<Object> GetObjectsWhichImplements(Type Contains, Assembly asm) {
            List<Type> Types = GetTypesWhichImplements(Contains, asm);
            List<Object> Objects = new List<Object>(Types.Count);
            Int32 Length = Types.Count;

            for (Int32 I = 0; I < Length; I++) {
                Objects[I] = Activator.CreateInstance(Types[I]);
            }

            return Objects;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Contains"></param>
        /// <returns></returns>
        public static List<T> GetObjectsWhichImplements<T>(Assembly asm) {
            List<Type> Types = GetTypesWhichImplements(typeof(T), asm);
            List<T> Objects = new List<T>(Types.Count);
            Int32 Length = Types.Count;

            for (Int32 I = 0; I < Length; I++) {
                Objects[I] = (T)Activator.CreateInstance(Types[I]);
            }

            return Objects;
        }
    }
}
