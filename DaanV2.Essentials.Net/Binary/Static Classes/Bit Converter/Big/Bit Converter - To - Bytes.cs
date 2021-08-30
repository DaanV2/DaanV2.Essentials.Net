/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;

namespace DaanV2.Binary {

    public static partial class BitConverter {
        public static partial class BigEndian {
            /// <summary>Converts the specified object into a <see cref="Byte"/> array</summary>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the specified object into a <see cref="Byte"/> array</returns>
            public static Byte[] ToBytes(Int16 Value) {
                return ToBytes((UInt16)Value);
            }

            /// <summary>Converts the specified object into a <see cref="Byte"/> array</summary>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the specified object into a <see cref="Byte"/> array</returns>
            public static Byte[] ToBytes(Int32 Value) {
                return ToBytes((UInt32)Value);
            }

            /// <summary>Converts the specified object into a <see cref="Byte"/> array</summary>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the specified object into a <see cref="Byte"/> array</returns>
            public static Byte[] ToBytes(Int64 Value) {
                return ToBytes((UInt64)Value);
            }

            /// <summary>Converts the specified object into a <see cref="Byte"/> array</summary>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the specified object into a <see cref="Byte"/> array</returns>
            public static Byte[] ToBytes(UInt16 Value) {
                Byte[] Out = new Byte[sizeof(UInt16)];
                //Providing constants removes boundaries checks
                OntoBytes(Out.AsSpan(0, sizeof(UInt16)), Value);

                return Out;
            }

            /// <summary>Converts the specified object into a <see cref="Byte"/> array</summary>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the specified object into a <see cref="Byte"/> array</returns>
            public static Byte[] ToBytes(UInt32 Value) {
                Byte[] Out = new Byte[sizeof(UInt32)];
                //Providing constants removes boundaries checks
                OntoBytes(Out.AsSpan(0, sizeof(UInt32)), Value);

                return Out;
            }

            /// <summary>Converts the specified object into a <see cref="Byte"/> array</summary>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the specified object into a <see cref="Byte"/> array</returns>
            public static Byte[] ToBytes(UInt64 Value) {
                Byte[] Out = new Byte[sizeof(UInt64)];
                //Providing constants removes boundaries checks
                OntoBytes(Out.AsSpan(0, sizeof(UInt64)), Value);

                return Out;
            }
        }
    }
}
