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

        /// <summary>Checks if the given type implement the given interface type</summary>
        /// <param name="Object">The object to look through</param>
        /// <param name="Contains">The interface type to find</param>
        /// <returns><see cref="Boolean"/></returns>
        public static Boolean ContainsInterface(this Type Object, Type Contains) {
            Type[] Interfaces = Object.GetInterfaces();

            if (Contains.IsGenericType) {
                for (Int32 I = 0; I < Interfaces.Length; I++) {
                    if (Interfaces[I].IsGenericType) {
                        if (Interfaces[I].GetGenericTypeDefinition() == Contains) {
                            return true;
                        }
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

        ///DOLATER <summary>Add Description</summary>
        /// <param name="Object"></param>
        /// <param name="Contains"></param>
        /// <returns></returns>
        public static Boolean ContainsAttribute(this Type Object, Type Contains, Boolean Inherit = true) {
            Object[] attributes = Object.GetCustomAttributes(Inherit);
            Int32 Length = attributes.Length;

            for (Int32 I = 0; I < Length; I++) {
                if (attributes[I].GetType() == Contains) {
                    return true;
                }
            }

            return false;
        }
    }
}
