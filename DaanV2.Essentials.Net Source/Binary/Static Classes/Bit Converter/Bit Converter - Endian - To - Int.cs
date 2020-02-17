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
    ///DOLATER <summary>add description for class: BitConverter</summary>
    public static partial class BitConverter {
        public static partial class Endian {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="Data"></param>
            /// <param name="endianness"></param>
            /// <returns></returns>
            public static Int16 ToInt16(Byte[] Data, Endianness endianness) {
                return endianness == Endianness.BigEndian ? 
                    BitConverter.BigEndian.ToInt16(Data) : 
                    BitConverter.LittleEndian.ToInt16(Data);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Data"></param>
            /// <param name="StartIndex"></param>
            /// <param name="endianness"></param>
            /// <returns></returns>
            public static Int16 ToInt16(Byte[] Data, Int32 StartIndex, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToInt16(Data, StartIndex) :
                    BitConverter.LittleEndian.ToInt16(Data, StartIndex);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Data"></param>
            /// <param name="endianness"></param>
            /// <returns></returns>
            public static Int32 ToInt32(Byte[] Data, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToInt32(Data) :
                    BitConverter.LittleEndian.ToInt32(Data);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Data"></param>
            /// <param name="StartIndex"></param>
            /// <param name="endianness"></param>
            /// <returns></returns>
            public static Int32 ToInt32(Byte[] Data, Int32 StartIndex, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToInt32(Data, StartIndex) :
                    BitConverter.LittleEndian.ToInt32(Data, StartIndex);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Data"></param>
            /// <param name="endianness"></param>
            /// <returns></returns>
            public static Int64 ToInt64(Byte[] Data, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToInt64(Data) :
                    BitConverter.LittleEndian.ToInt64(Data);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Data"></param>
            /// <param name="StartIndex"></param>
            /// <param name="endianness"></param>
            /// <returns></returns>
            public static Int64 ToInt64(Byte[] Data, Int32 StartIndex, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToInt64(Data, StartIndex) :
                    BitConverter.LittleEndian.ToInt64(Data, StartIndex);
            }
        }
    }
}
