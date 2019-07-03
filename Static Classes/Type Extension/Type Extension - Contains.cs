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
    public static partial class TypeExtension {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static Object GetAttribute(this Type Object, Type Value) {
            Object[] Attributes = Object.GetCustomAttributes(Value, true);

            for (Int32 I = 0; I < Attributes.Length; I++) {
                if (Attributes[I].GetType() == Value) {
                    return Attributes[I];
                }
            }

            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetAttribute<T>(this Type Object) {
            Type Find = typeof(T);
            Object[] Attributes = Object.GetCustomAttributes(Find, true);

            for (Int32 I = 0; I < Attributes.Length; I++) {
                if (Attributes[I].GetType() == Find) {
                    return (T)Attributes[I];
                }
            }

            return default;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Object"></param>
        /// <param name="Contains"></param>
        /// <returns></returns>
        public static Boolean ContainsInterface(this Type Object, Type Contains) {
            Type[] Interfaces = Object.GetInterfaces();

            if (Contains.IsGenericType) {
                for (Int32 I = 0; I < Interfaces.Length; I++) {
                    if (Interfaces[I].GetGenericTypeDefinition() == Contains) return true;
                }
            }
            else {
                for (Int32 I = 0; I < Interfaces.Length; I++) {
                    if (Interfaces[I] == Contains) return true;
                }
            }

            return false;
        }
    }
}
