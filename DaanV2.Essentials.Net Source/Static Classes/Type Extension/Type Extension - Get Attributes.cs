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
    public static partial class TypeExtension {
        /// <summary>Returns the specified attribute.</summary>
        /// <param name="Object">The object to retrieve attributes from.</param>
        /// <param name="Value">The type of the attribute to return.</param>
        /// <returns>Returns the specified attribute.</returns>
        public static Object GetAttribute(this Type Object, Type Value) {
            Object[] Attributes = Object.GetCustomAttributes(Value, true);

            for (Int32 I = 0; I < Attributes.Length; I++) {
                if (Attributes[I].GetType() == Value) {
                    return Attributes[I];
                }
            }

            return default;
        }

        /// <summary>Returns the specified attribute.</summary>
        /// <param name="Object">The object to retrieve attributes from.</param>
        /// <typeparam name="T">The type of the attribute to return.</typeparam>
        /// <returns>Returns the specified attribute.</returns>
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

        /// <summary>Returns the specified attributes.</summary>
        /// <param name="Object">The object to retrieve attributes from.</param>
        /// <param name="Value">The type of the attribute to return.</param>
        /// <returns>Returns the specified attributes.</returns>
        public static List<Object> GetAttributes(this Type Object, Type Value) {
            Object[] Attributes = Object.GetCustomAttributes(Value, true);
            Int32 Length = Attributes.Length;
            List<Object> Out = new List<Object>(Length);

            for (Int32 I = 0; I < Length; I++) {
                if (Attributes[I].GetType() == Value) {
                    Out.Add(Attributes[I]);
                }
            }

            return Out;
        }

        /// <summary>Returns the specified attributes.</summary>
        /// <param name="Object">The object to retrieve attributes from.</param>
        /// <typeparam name="T">The type of the attribute to return.</typeparam>
        /// <returns>Returns the specified attributes.</returns>
        public static List<T> GetAttributes<T>(this Type Object) {
            Type Find = typeof(T);
            Object[] Attributes = Object.GetCustomAttributes(Find, true);
            Int32 Length = Attributes.Length;
            List<T> Out = new List<T>(Length);

            for (Int32 I = 0; I < Length; I++) {
                if (Attributes[I].GetType() == Find) {
                    Out.Add((T)Attributes[I]);
                }
            }

            return Out;
        }
    }
}
