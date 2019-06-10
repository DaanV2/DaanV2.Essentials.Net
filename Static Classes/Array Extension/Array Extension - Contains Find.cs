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
