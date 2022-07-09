/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Collections.Generic;

namespace DaanV2 {
    public static partial class CollectionExtension {
        /// <summary>Returns a copy of the whole list.</summary>
        /// <param name="values">The list of values to copy.</param>
        /// <returns>Returns a copy of the whole list.</returns>
        public static List<String> Copy(this List<String> values) {
            Int32 Max = values.Count;
            var Out = new List<String>(Max);

            for (Int32 I = 0; I < Max; I++) {
                Out.Add(StringExtension.Copy(values[I]));
            }

            return Out;
        }

        /// <summary>Returns a copy of the whole array.</summary>
        /// <param name="values">The array of values to copy.</param>
        /// <returns>Returns a copy of the whole array.</returns>
        public static String[] Copy(this String[] values) {
            Int32 Max = values.Length;
            String[] Out = new String[Max];

            for (Int32 I = 0; I < Max; I++) {
                Out[I] = StringExtension.Copy(values[I]);
            }

            return Out;
        }

        /// <summary>Replaces value inside the array.</summary>
        /// <param name="Values">The values to loop through.</param>
        /// <param name="Old">The value to replace.</param>
        /// <param name="New">The value to add into.</param>
        public static void Replace(this String[] Values, String Old, String New) {
            Int32 Max = Values.Length;

            for (Int32 I = 0; I < Max; I++) {
                Values[I] = Values[I].Replace(Old, New);
            }
        }

        /// <summary>Replaces value inside the list.</summary>
        /// <param name="Values">The values to loop through.</param>
        /// <param name="Old">The value to replace.</param>
        /// <param name="New">The value to add into.</param>
        public static void Replace(this IList<String> Values, String Old, String New) {
            Int32 Max = Values.Count;

            for (Int32 I = 0; I < Max; I++) {
                Values[I] = Values[I].Replace(Old, New);
            }
        }
    }
}