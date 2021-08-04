/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.


THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;

namespace DaanV2.Binary {
    
    public static partial class BitConverter {
        public static partial class Endian {
            /// <summary>Converts the given value into a byte array</summary>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">marks which endianness should be used</param>
            /// <returns>Converts the given value into a byte arrays</returns>
            public static Byte[] ToBytes(Int16 Value, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToBytes(Value) :
                    BitConverter.LittleEndian.ToBytes(Value);
            }

            /// <summary>Converts the given value into a byte array</summary>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">marks which endianness should be used</param>
            /// <returns>Converts the given value into a byte arrays</returns>
            public static Byte[] ToBytes(Int32 Value, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToBytes(Value) :
                    BitConverter.LittleEndian.ToBytes(Value);
            }

            /// <summary>Converts the given value into a byte array</summary>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">marks which endianness should be used</param>
            /// <returns>Converts the given value into a byte arrays</returns>
            public static Byte[] ToBytes(Int64 Value, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToBytes(Value) :
                    BitConverter.LittleEndian.ToBytes(Value);
            }

            /// <summary>Converts the given value into a byte array</summary>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">marks which endianness should be used</param>
            /// <returns>Converts the given value into a byte arrays</returns>
            public static Byte[] ToBytes(UInt16 Value, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToBytes(Value) :
                    BitConverter.LittleEndian.ToBytes(Value);
            }

            /// <summary>Converts the given value into a byte array</summary>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">marks which endianness should be used</param>
            /// <returns>Converts the given value into a byte arrays</returns>
            public static Byte[] ToBytes(UInt32 Value, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToBytes(Value) :
                    BitConverter.LittleEndian.ToBytes(Value);
            }

            /// <summary>Converts the given value into a byte array</summary>
            /// <param name="Value">The object to convert</param>
            /// <param name="endianness">marks which endianness should be used</param>
            /// <returns>Converts the given value into a byte arrays</returns>
            public static Byte[] ToBytes(UInt64 Value, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToBytes(Value) :
                    BitConverter.LittleEndian.ToBytes(Value);
            }
        }
    }
}
