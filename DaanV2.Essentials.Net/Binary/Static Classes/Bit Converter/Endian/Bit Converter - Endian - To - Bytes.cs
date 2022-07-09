/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;

namespace DaanV2.Binary {

    public static partial class BitConverter {
        public static partial class Endian {
            /// <summary>Converts the given value into a <see cref="Byte"/> array</summary>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">marks which endianness should be used</param>
            /// <returns>Converts the given value into a <see cref="Byte"/> arrays</returns>
            public static Byte[] ToBytes(Int16 Value, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToBytes(Value) :
                    BitConverter.LittleEndian.ToBytes(Value);
            }

            /// <summary>Converts the given value into a <see cref="Byte"/> array</summary>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">marks which endianness should be used</param>
            /// <returns>Converts the given value into a <see cref="Byte"/> arrays</returns>
            public static Byte[] ToBytes(Int32 Value, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToBytes(Value) :
                    BitConverter.LittleEndian.ToBytes(Value);
            }

            /// <summary>Converts the given value into a <see cref="Byte"/> array</summary>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">marks which endianness should be used</param>
            /// <returns>Converts the given value into a <see cref="Byte"/> arrays</returns>
            public static Byte[] ToBytes(Int64 Value, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToBytes(Value) :
                    BitConverter.LittleEndian.ToBytes(Value);
            }

            /// <summary>Converts the given value into a <see cref="Byte"/> array</summary>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">marks which endianness should be used</param>
            /// <returns>Converts the given value into a <see cref="Byte"/> arrays</returns>
            public static Byte[] ToBytes(UInt16 Value, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToBytes(Value) :
                    BitConverter.LittleEndian.ToBytes(Value);
            }

            /// <summary>Converts the given value into a <see cref="Byte"/> array</summary>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">marks which endianness should be used</param>
            /// <returns>Converts the given value into a <see cref="Byte"/> arrays</returns>
            public static Byte[] ToBytes(UInt32 Value, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToBytes(Value) :
                    BitConverter.LittleEndian.ToBytes(Value);
            }

            /// <summary>Converts the given value into a <see cref="Byte"/> array</summary>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">marks which endianness should be used</param>
            /// <returns>Converts the given value into a <see cref="Byte"/> arrays</returns>
            public static Byte[] ToBytes(UInt64 Value, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToBytes(Value) :
                    BitConverter.LittleEndian.ToBytes(Value);
            }
        }
    }
}