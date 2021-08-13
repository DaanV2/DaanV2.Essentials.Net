/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Collections.Generic;
using System.Reflection;

namespace DaanV2 {
    public static partial class TypeExtension {
        /// <summary>Returns a list of types that implement the specified implement.</summary>
        /// <param name="Implements">The type that should be implemented.</param>
        /// <returns>Returns a list of types that implement the specified implement.</returns>
        public static List<Type> GetTypesWhichImplements(Type Implements) {
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            Int32 Length = assemblies.Length;
            List<Type> Out = new List<Type>(100);

            for (Int32 I = 0; I < Length; I++) {
                Out.AddRange(GetTypesWhichImplements(Implements, assemblies[I]));
            }

            return Out;
        }

        /// <summary>Returns a list of types that implement the specified implement.</summary>
        /// <param name="Implements">The type that should be implemented.</param>
        /// <param name="asm">the assemblies to look through.</param>
        /// <returns>Returns a list of types that implement the specified implement.</returns>
        public static List<Type> GetTypesWhichImplements(Type Implements, Assembly asm) {
            List<Type> Out = new List<Type>(100);
            try {
                Type[] Types = asm.GetTypes();

                Int32 Length = Types.Length;

                for (Int32 I = 0; I < Length; I++) {
                    if (Types[I].Implements(Implements)) {
                        Out.Add(Types[I]);
                    }
                }
            }
            catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

            return Out;
        }
    }
}
