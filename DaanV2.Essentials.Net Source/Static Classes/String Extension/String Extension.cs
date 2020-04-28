using System;

namespace DaanV2 {
    /// <summary>The static class that add upon existing code.</summary>
    public static partial class StringExtension {
        /// <summary>Creates a copy of the specified string.</summary>
        /// <param name="Value">The string to copy.</param>
        /// <returns>Creates a copy of the specified string.</returns>
        public static String Copy(this String Value) {
            Char[] Source = Value.ToCharArray();
            Char[] Destination = new Char[Source.Length];

            Array.Copy(Source, Destination, Destination.Length);
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
