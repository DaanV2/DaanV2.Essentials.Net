﻿/*ISC License

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
        public static partial class BigEndian {
            /// <summary>Converts the given byte array to an <see cref="Int16"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <returns>Converts the given byte array to an <see cref="Int16"/></returns>
            public static Int16 ToInt16(Byte[] Data) {
                Int16 Out;

                if (Data == null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                if (Data.Length < sizeof(Int16)) {
                    throw new ArgumentException($"{nameof(Data)} is not of length 4 atleast");
                }

#if UNSAFE
                unsafe {                    
                    Byte* d = (Byte*)&Out;

                    *d = Data[1];
                    *(d + 1) = Data[0];
                }
#else
                Out = Data[1];
                Out |= (Int16)(Data[0] << 8);
#endif

                return Out;
            }
            
            /// <summary>Converts the given byte array to an <see cref="Int16"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given byte array to an <see cref="Int16"/></returns>
            public static Int16 ToInt16(Byte[] Data, Int32 StartIndex) {
                Int16 Out;

                if (Data == null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                if (Data.Length < sizeof(Int16) + StartIndex) {
                    throw new ArgumentException($"{nameof(Data)} is not of proper length atleast");
                }

#if UNSAFE
                unsafe {                    
                    Byte* d = (Byte*)&Out;

                    *d = Data[1 + StartIndex];
                    *(d + 1) = Data[StartIndex];
                }
#else
                Out = Data[1 + StartIndex];
                Out |= (Int16)(Data[StartIndex] << 8);
#endif

                return Out;
            }

            /// <summary>Converts the given byte array to an <see cref="Int32"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <returns>Converts the given byte array to an <see cref="Int32"/></returns>
            public static Int32 ToInt32(Byte[] Data) {
                Int32 Out;

                if (Data == null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                if (Data.Length < sizeof(Int32)) {
                    throw new ArgumentException($"{nameof(Data)} is not of proper length atleast");
                }

#if UNSAFE
                unsafe {                
                    Byte* d = (Byte*)&Out;

                    *d = Data[3];
                    *(d + 1) = Data[2];
                    *(d + 2) = Data[1];
                    *(d + 3) = Data[0];
                }
#else
                Out = Data[3];
                Out |= Data[2] << 8;
                Out |= Data[1] << 16;
                Out |= Data[0] << 24;
#endif

                return Out;
            }

            /// <summary>Converts the given byte array to an <see cref="Int32"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given byte array to an <see cref="Int32"/></returns>
            public static Int32 ToInt32(Byte[] Data, Int32 StartIndex) {
                Int32 Out;

                if (Data == null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                if (Data.Length < sizeof(Int32) + StartIndex) {
                    throw new ArgumentException($"{nameof(Data)} is not of length 4 atleast");
                }

#if UNSAFE
                unsafe {                    
                    Byte* d = (Byte*)&Out;

                    *d = Data[3 + StartIndex];
                    *(d + 1) = Data[2 + StartIndex];
                    *(d + 2) = Data[1 + StartIndex];
                    *(d + 3) = Data[StartIndex];
                }
#else
                Out = Data[3 + StartIndex];
                Out |= Data[2 + StartIndex] << 8;
                Out |= Data[1 + StartIndex] << 16;
                Out |= Data[StartIndex] << 24;
#endif

                return Out;
            }

            /// <summary>Converts the given byte array to an <see cref="Int64"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <returns>Converts the given byte array to an <see cref="Int64"/></returns>
            public static Int64 ToInt64(Byte[] Data) {
                Int64 Out;

                if (Data == null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                if (Data.Length < sizeof(Int64)) {
                    throw new ArgumentException($"{nameof(Data)} is not of length 8 atleast");
                }

#if UNSAFE
                unsafe {
                    
                        Byte* d = (Byte*)&Out;

                        *d = Data[7];
                        *(d + 1) = Data[6];
                        *(d + 2) = Data[5];
                        *(d + 3) = Data[4];
                        *(d + 4) = Data[3];
                        *(d + 5) = Data[2];
                        *(d + 6) = Data[1];
                        *(d + 7) = Data[0];
                }
#else
                Out = Data[7];
                Out |= ((Int64)Data[6] << 8);
                Out |= ((Int64)Data[5] << 16);
                Out |= ((Int64)Data[4] << 24);
                Out |= ((Int64)Data[3] << 32);
                Out |= ((Int64)Data[2] << 40);
                Out |= ((Int64)Data[1] << 48);
                Out |= ((Int64)Data[0] << 56);
#endif

                return Out;
            }

            /// <summary>Converts the given byte array to an <see cref="Int64"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given byte array to an <see cref="Int64"/></returns>
            public static Int64 ToInt64(Byte[] Data, Int32 StartIndex) {
                Int64 Out;

                if (Data == null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                if (Data.Length < sizeof(Int64) + StartIndex) {
                    throw new ArgumentException($"{nameof(Data)} is not of proper length atleast");
                }

#if UNSAFE
                unsafe {                    
                    Byte* d = (Byte*)&Out;

                    *d = Data[7 + StartIndex];
                    *(d + 1) = Data[6 + StartIndex];
                    *(d + 2) = Data[5 + StartIndex];
                    *(d + 3) = Data[4 + StartIndex];
                    *(d + 4) = Data[3 + StartIndex];
                    *(d + 5) = Data[2 + StartIndex];
                    *(d + 6) = Data[1 + StartIndex];
                    *(d + 7) = Data[StartIndex];
                }
#else
                Out = Data[7 + StartIndex];
                Out |= (Int64)Data[6 + StartIndex] << 8;
                Out |= (Int64)Data[5 + StartIndex] << 16;
                Out |= (Int64)Data[4 + StartIndex] << 24;
                Out |= (Int64)Data[3 + StartIndex] << 32;
                Out |= (Int64)Data[2 + StartIndex] << 40;
                Out |= (Int64)Data[1 + StartIndex] << 48;
                Out |= (Int64)Data[0 + StartIndex] << 56;
#endif

                return Out;
            }
        }
    }
}
