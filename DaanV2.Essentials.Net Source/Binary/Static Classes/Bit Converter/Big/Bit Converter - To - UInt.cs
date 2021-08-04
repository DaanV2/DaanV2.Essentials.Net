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
        public static partial class BigEndian {
            /// <summary>Converts the given byte array to an <see cref="UInt16"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <returns>Converts the given byte array to an <see cref="UInt16"/></returns>
            public static UInt16 ToUInt16(Byte[] Data) {
                UInt16 Out;

                if (Data == null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                if (Data.Length < sizeof(UInt16)) {
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
                Out |= (UInt16)(Data[0] << 8);
#endif

                return Out;
            }

            /// <summary>Converts the given byte array to an <see cref="UInt16"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given byte array to an <see cref="UInt16"/></returns>
            public static UInt16 ToUInt16(Byte[] Data, Int32 StartIndex) {
                UInt16 Out;

                if (Data == null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                if (Data.Length < sizeof(UInt16) + StartIndex) {
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
                Out |= (UInt16)(Data[StartIndex] << 8);
#endif

                return Out;
            }

            /// <summary>Converts the given byte array to an <see cref="UInt32"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <returns>Converts the given byte array to an <see cref="UInt32"/></returns>
            public static UInt32 ToUInt32(Byte[] Data) {
                UInt32 Out;

                if (Data == null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                if (Data.Length < sizeof(UInt32)) {
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
                Out |= (UInt32)Data[2] << 8;
                Out |= (UInt32)Data[1] << 16;
                Out |= (UInt32)Data[0] << 24;
#endif

                return Out;
            }

            /// <summary>Converts the given byte array to an <see cref="UInt32"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given byte array to an <see cref="UInt32"/></returns>
            public static UInt32 ToUInt32(Byte[] Data, Int32 StartIndex) {
                UInt32 Out;

                if (Data == null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                if (Data.Length < sizeof(UInt32) + StartIndex) {
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
                Out |= (UInt32)Data[2 + StartIndex] << 8;
                Out |= (UInt32)Data[1 + StartIndex] << 16;
                Out |= (UInt32)Data[StartIndex] << 24;
#endif

                return Out;
            }

            /// <summary>Converts the given byte array to an <see cref="UInt64"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <returns>Converts the given byte array to an <see cref="UInt64"/></returns>
            public static UInt64 ToUInt64(Byte[] Data) {
                UInt64 Out;

                if (Data == null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                if (Data.Length < sizeof(UInt64)) {
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
#pragma warning disable CS0675 // Bitwise-or operator used on a sign-extended operand
                Out = Data[7];

                Out |= ((UInt64)Data[6] << 8);
                Out |= ((UInt64)Data[5] << 16);
                Out |= ((UInt64)Data[4] << 24);
                Out |= ((UInt64)Data[3] << 32);
                Out |= ((UInt64)Data[2] << 40);
                Out |= ((UInt64)Data[1] << 48);
                Out |= ((UInt64)Data[0] << 56);
#pragma warning restore CS0675 // Bitwise-or operator used on a sign-extended operand
#endif

                return Out;
            }

            /// <summary>Converts the given byte array to an <see cref="UInt64"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given byte array to an <see cref="UInt64"/></returns>
            public static UInt64 ToUInt64(Byte[] Data, Int32 StartIndex) {
                UInt64 Out;

                if (Data == null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                if (Data.Length < sizeof(UInt64) + StartIndex) {
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
#pragma warning disable CS0675 // Bitwise-or operator used on a sign-extended operand
                Out = Data[7 + StartIndex];
                Out |= ((UInt64)Data[6 + StartIndex] << 8);
                Out |= ((UInt64)Data[5 + StartIndex] << 16);
                Out |= ((UInt64)Data[4 + StartIndex] << 24);
                Out |= ((UInt64)Data[3 + StartIndex] << 32);
                Out |= ((UInt64)Data[2 + StartIndex] << 40);
                Out |= ((UInt64)Data[1 + StartIndex] << 48);
                Out |= ((UInt64)Data[0 + StartIndex] << 56);
#pragma warning restore CS0675 // Bitwise-or operator used on a sign-extended operand
#endif

                return Out;
            }
        }
    }
}
