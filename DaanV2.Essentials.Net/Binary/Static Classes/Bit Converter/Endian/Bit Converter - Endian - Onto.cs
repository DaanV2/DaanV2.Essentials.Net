/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;

namespace DaanV2.Binary {
    public static partial class BitConverter {
        public static partial class Endian {
            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            public static void OntoBytes(Byte[] Receiver, Int16 Value, Endianness endianness, Int32 StartIndex = 0) {
                if (endianness == Endianness.BigEndian)
                    BigEndian.OntoBytes(Receiver, Value, StartIndex);
                else
                    LittleEndian.OntoBytes(Receiver, Value, StartIndex);
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            public static void OntoBytes(Byte[] Receiver, Int32 Value, Endianness endianness, Int32 StartIndex = 0) {
                if (endianness == Endianness.BigEndian)
                    BigEndian.OntoBytes(Receiver, Value, StartIndex);
                else
                    LittleEndian.OntoBytes(Receiver, Value, StartIndex);
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            public static void OntoBytes(Byte[] Receiver, Int64 Value, Endianness endianness, Int32 StartIndex = 0) {
                if (endianness == Endianness.BigEndian)
                    BigEndian.OntoBytes(Receiver, Value, StartIndex);
                else
                    LittleEndian.OntoBytes(Receiver, Value, StartIndex);
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            public static void OntoBytes(Byte[] Receiver, UInt16 Value, Endianness endianness, Int32 StartIndex = 0) {
                if (endianness == Endianness.BigEndian)
                    BigEndian.OntoBytes(Receiver, Value, StartIndex);
                else
                    LittleEndian.OntoBytes(Receiver, Value, StartIndex);
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            public static void OntoBytes(Byte[] Receiver, UInt32 Value, Endianness endianness, Int32 StartIndex = 0) {
                if (endianness == Endianness.BigEndian)
                    BigEndian.OntoBytes(Receiver, Value, StartIndex);
                else
                    LittleEndian.OntoBytes(Receiver, Value, StartIndex);
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            public static void OntoBytes(Byte[] Receiver, UInt64 Value, Endianness endianness, Int32 StartIndex = 0) {
                if (endianness == Endianness.BigEndian)
                    BigEndian.OntoBytes(Receiver, Value, StartIndex);
                else
                    LittleEndian.OntoBytes(Receiver, Value, StartIndex);
            }
        }
    }
}
