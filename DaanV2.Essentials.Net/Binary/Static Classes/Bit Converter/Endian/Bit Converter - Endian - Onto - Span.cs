using System;

namespace DaanV2.Binary {
    public static partial class BitConverter {
        public static partial class Endian {
            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            public static void OntoBytes(Span<Byte> Receiver, Int16 Value, Endianness endianness) {
                if (endianness == Endianness.BigEndian)
                    BigEndian.OntoBytes(Receiver, Value);
                else
                    LittleEndian.OntoBytes(Receiver, Value);
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            public static void OntoBytes(Span<Byte> Receiver, Int32 Value, Endianness endianness) {
                if (endianness == Endianness.BigEndian)
                    BigEndian.OntoBytes(Receiver, Value);
                else
                    LittleEndian.OntoBytes(Receiver, Value);
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            public static void OntoBytes(Span<Byte> Receiver, Int64 Value, Endianness endianness) {
                if (endianness == Endianness.BigEndian)
                    BigEndian.OntoBytes(Receiver, Value);
                else
                    LittleEndian.OntoBytes(Receiver, Value);
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            public static void OntoBytes(Span<Byte> Receiver, UInt16 Value, Endianness endianness) {
                if (endianness == Endianness.BigEndian)
                    BigEndian.OntoBytes(Receiver, Value);
                else
                    LittleEndian.OntoBytes(Receiver, Value);
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            public static void OntoBytes(Span<Byte> Receiver, UInt32 Value, Endianness endianness) {
                if (endianness == Endianness.BigEndian)
                    BigEndian.OntoBytes(Receiver, Value);
                else
                    LittleEndian.OntoBytes(Receiver, Value);
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            public static void OntoBytes(Span<Byte> Receiver, UInt64 Value, Endianness endianness) {
                if (endianness == Endianness.BigEndian)
                    BigEndian.OntoBytes(Receiver, Value);
                else
                    LittleEndian.OntoBytes(Receiver, Value);
            }
        }
    }
}