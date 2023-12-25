using System;
using System.Collections.Generic;
using System.Reflection;

namespace DaanV2 {
    public static partial class TypeExtension {
        /// <summary>Returns a list of object that implements a specified type.</summary>
        /// <param name="Contains">The type to search for.</param>
        /// <returns>Returns a list of object that implements a specified type.</returns>
        public static List<Object> GetObjectsWhichImplements(Type Contains) {
            List<Type> Types = GetTypesWhichImplements(Contains);
            var Objects = new List<Object>(Types.Count);
            Int32 Length = Types.Count;

            for (Int32 I = 0; I < Length; I++) {
                Objects[I] = Activator.CreateInstance(Types[I]);
            }

            return Objects;
        }

        /// <summary>Returns a list of object that implements a specified type.</summary>
        /// <returns>Returns a list of object that implements a specified type.</returns>
        public static List<T> GetObjectsWhichImplements<T>() {
            List<Type> Types = GetTypesWhichImplements(typeof(T));
            var Objects = new List<T>(Types.Count);
            Int32 Length = Types.Count;
            Type Current;

            for (Int32 I = 0; I < Length; I++) {
                Current = Types[I];

                if (!Current.IsInterface && !Current.IsAbstract) {
                    Objects.Add((T)Activator.CreateInstance(Types[I]));
                }
            }

            return Objects;
        }

        /// <summary>Returns a list of object that implements a specified type.</summary>
        /// <param name="Contains">The type to search for.</param>
        /// <param name="asm">The assemblies to look through.</param>
        /// <returns>Returns a list of object that implements a specified type.</returns>
        public static List<Object> GetObjectsWhichImplements(Type Contains, Assembly asm) {
            List<Type> Types = GetTypesWhichImplements(Contains, asm);
            var Objects = new List<Object>(Types.Count);
            Int32 Length = Types.Count;

            for (Int32 I = 0; I < Length; I++) {
                Objects[I] = Activator.CreateInstance(Types[I]);
            }

            return Objects;
        }

        /// <summary>Returns a list of object that implements a specified type.</summary>
        /// <param name="asm">The assemblies to look through.</param>
        /// <typeparam name="T">The type to find.</typeparam>
        /// <returns>Returns a list of object that implements a specified type.</returns>
        public static List<T> GetObjectsWhichImplements<T>(Assembly asm) {
            List<Type> Types = GetTypesWhichImplements(typeof(T), asm);
            var Objects = new List<T>(Types.Count);
            Int32 Length = Types.Count;

            for (Int32 I = 0; I < Length; I++) {
                Objects[I] = (T)Activator.CreateInstance(Types[I]);
            }

            return Objects;
        }
    }
}