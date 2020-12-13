using System;

namespace DaanV2 {
    /// <summary>The static class that add upon existing code.</summary>
    public static partial class StringExtension {
        /// <summary>Creates a copy of the specified string.</summary>
        /// <param name="Value">The string to copy.</param>
        /// <returns>Creates a copy of the specified string.</returns>
        public static String Copy(this String Value) {
            Int32 Length = Value.Length;
            Char[] Destination = new Char[Length];

            for (Int32 I = 0; I < Length; I++) {
                Destination[I] = Value[I];
            }

            return new String(Destination);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="StartsWith"></param>
        /// <returns></returns>
        public static Boolean StartWith(this String Value, Char StartsWith) {
            return Value[0] == StartsWith;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="StartsWith"></param>
        /// <returns></returns>
        public static Boolean StartWith(this String Value, Char[] StartsWith) {
            Char C = Value[0];

            for (Int32 I = 0; I < StartsWith.Length; I++) {
                if (C == StartsWith[I]) {
                    return true;
                }
            }

            return false;
        }
    }
}
