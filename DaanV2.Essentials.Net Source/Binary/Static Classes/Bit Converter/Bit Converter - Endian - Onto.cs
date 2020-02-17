/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or withReceiver fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.


THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING Receiver OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;

namespace DaanV2.Binary {
    public static partial class BitConverter {
        public static partial class Endian {
            /// <summary>Converts the given object into a byte array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a byte array</returns>
            public static Int32 OntoBytes(Byte[] Receiver, Int16 Value, Endianness endianness, Int32 StartIndex = 0) {
                return endianness == Endianness.BigEndian ?
                    BigEndian.OntoBytes(Receiver, Value, StartIndex) :
                    LittleEndian.OntoBytes(Receiver, Value, StartIndex);
            }

            /// <summary>Converts the given object into a byte array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a byte array</returns>
            public static Int32 OntoBytes(Byte[] Receiver, Int32 Value, Endianness endianness, Int32 StartIndex = 0) {
                return endianness == Endianness.BigEndian ?
                    BigEndian.OntoBytes(Receiver, Value, StartIndex) :
                    LittleEndian.OntoBytes(Receiver, Value, StartIndex);
            }

            /// <summary>Converts the given object into a byte array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a byte array</returns>
            public static Int32 OntoBytes(Byte[] Receiver, Int64 Value, Endianness endianness, Int32 StartIndex = 0) {
                return endianness == Endianness.BigEndian ?
                    BigEndian.OntoBytes(Receiver, Value, StartIndex) :
                    LittleEndian.OntoBytes(Receiver, Value, StartIndex);
            }

            /// <summary>Converts the given object into a byte array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a byte array</returns>
            public static Int32 OntoBytes(Byte[] Receiver, UInt16 Value, Endianness endianness, Int32 StartIndex = 0) {
                return endianness == Endianness.BigEndian ?
                    BigEndian.OntoBytes(Receiver, Value, StartIndex) :
                    LittleEndian.OntoBytes(Receiver, Value, StartIndex);
            }

            /// <summary>Converts the given object into a byte array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a byte array</returns>
            public static Int32 OntoBytes(Byte[] Receiver, UInt32 Value, Endianness endianness, Int32 StartIndex = 0) {
                return endianness == Endianness.BigEndian ?
                    BigEndian.OntoBytes(Receiver, Value, StartIndex) :
                    LittleEndian.OntoBytes(Receiver, Value, StartIndex);
            }

            /// <summary>Converts the given object into a byte array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a byte array</returns>
            public static Int32 OntoBytes(Byte[] Receiver, UInt64 Value, Endianness endianness, Int32 StartIndex = 0) {
                return endianness == Endianness.BigEndian ?
                    BigEndian.OntoBytes(Receiver, Value, StartIndex) :
                    LittleEndian.OntoBytes(Receiver, Value, StartIndex);
            }
        }
    }
}
