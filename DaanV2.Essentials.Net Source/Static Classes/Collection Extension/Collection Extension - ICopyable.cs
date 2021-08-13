/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Collections.Generic;

namespace DaanV2 {
    public static partial class CollectionExtension {
        /// <summary>Returns a copy of the whole list.</summary>
        /// <typeparam name="T">The type of element in the list that implements <see cref="ICopyable{T}"/>.</typeparam>
        /// <param name="values">the list of values to be copied.</param>
        /// <returns>Returns a copy of the whole list.</returns>
        public static List<T> Copy<T>(this List<T> values)
            where T : ICopyable<T> {
            Int32 Max = values.Count;
            List<T> Out = new List<T>(Max);

            for (Int32 I = 0; I < Max; I++) {
                Out.Add(values[I].Copy());
            }

            return Out;
        }

        /// <summary>Returns a copy of the whole array.</summary>
        /// <typeparam name="T">The type of element in the array that implements <see cref="ICopyable{T}"/>.</typeparam>
        /// <param name="values">the array of values to be copied.</param>
        /// <returns>Returns a copy of the whole array.</returns>
        public static T[] Copy<T>(this T[] values)
            where T : ICopyable<T> {
            Int32 Max = values.Length;
            T[] Out = new T[Max];

            for (Int32 I = 0; I < Max; I++) {
                Out[I] = values[I].Copy();
            }

            return Out;
        }

        /// <summary>Returns a copy of the whole list.</summary>
        /// <typeparam name="T">The type of element in the list that implements <see cref="ICopyable{T}"/>.</typeparam>
        /// <param name="values">the list of values to be copied.</param>
        /// <returns>Returns a <see cref="IList{T}"/>.</returns>
        public static List<T> Copy<T>(this IList<T> values)
            where T : ICopyable<T> {
            Int32 Max = values.Count;
            List<T> Out = new List<T>(Max);

            for (Int32 I = 0; I < Max; I++) {
                Out.Add(values[I].Copy());
            }

            return Out;
        }
    }
}
