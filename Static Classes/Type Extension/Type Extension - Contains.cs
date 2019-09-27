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
    /// <summary>The class that extends op on the existing type code</summary>
    public static partial class TypeExtension {

        /// <summary>Returns the given attribute</summary>
        /// <param name="Object">The object to retrieve attributes from</param>
        /// <param name="Value">The type of the attribute to return</param>
        /// <returns><see cref="Object"/></returns>
        public static Object GetAttribute(this Type Object, Type Value) {
            Object[] Attributes = Object.GetCustomAttributes(Value, true);

            for (Int32 I = 0; I < Attributes.Length; I++) {
                if (Attributes[I].GetType() == Value) {
                    return Attributes[I];
                }
            }

            return default;
        }

        /// <summary>Returns the given attribute</summary>
        /// <param name="Object">The object to retrieve attributes from</param>
        /// <typeparam name="T">The type of the attribute to return</typeparam>
        /// <returns><see cref="T"/></returns>
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

        /// <summary>Checks if the given type implement the given interface type</summary>
        /// <param name="Object">The object to look through</param>
        /// <param name="Contains">The interface type to find</param>
        /// <returns><see cref="Boolean"/></returns>
        public static Boolean ContainsInterface(this Type Object, Type Contains) {
            Type[] Interfaces = Object.GetInterfaces();

            if (Contains.IsGenericType) {
                for (Int32 I = 0; I < Interfaces.Length; I++) {
                    if (Interfaces[I].GetGenericTypeDefinition() == Contains) {
                        return true;
                    }
                }
            }
            else {
                for (Int32 I = 0; I < Interfaces.Length; I++) {
                    if (Interfaces[I] == Contains) {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
