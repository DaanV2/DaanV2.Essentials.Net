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
        /// <summary>Returns a list of types that implement the specified implement</summary>
        /// <param name="Implements">The type that should be implemented</param>
        /// <returns>Returns a list of types that implement the specified implement</returns>
        public static List<Type> GetTypesWhichImplements(Type Implements) {
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            Int32 Length = assemblies.Length;
            List<Type> Out = new List<Type>(100);

            for (Int32 I = 0; I < Length; I++) {
                Out.AddRange(GetTypesWhichImplements(Implements, assemblies[I]));
            }

            return Out;
        }

        /// <summary>Returns a list of types that implement the specified implement</summary>
        /// <param name="Implements">The type that should be implemented</param>
        /// <param name="asm">the assemblies to look through</param>
        /// <returns>Returns a list of types that implement the specified implement</returns>
        public static List<Type> GetTypesWhichImplements(Type Implements, Assembly asm) {
            Type[] Types = asm.GetTypes();
            List<Type> Out = new List<Type>(100);
            Int32 Length = Types.Length;

            for (Int32 I = 0; I < Length; I++) {
                if (Types[I].Implements(Implements)) {
                    Out.Add(Types[I]);
                }
            }

            return Out;
        }
    }
}
