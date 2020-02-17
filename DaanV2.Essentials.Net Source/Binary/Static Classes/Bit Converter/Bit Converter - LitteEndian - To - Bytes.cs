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
        public static partial class LittleEndian {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="Value"></param>
            public static Byte[] ToBytes(Int16 Value) {
#if UNSAFE
                Byte[] Out = new Byte[sizeof(Int16)];

                unsafe {
                    Byte* s = (Byte*)&Value;

                    Out[0] = *s;
                    Out[1] = *(s + 1);
                }
#else
                Int32 Count = sizeof(Int16);
                Byte[] Out = new Byte[Count];

                for (Int32 I = 0; I < Count; I++) {
                    Out[I] = (Byte)(Value & BitConverter._ByteOnlyMask);
                    Value >>= 8;
                }
#endif

                return Out;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Value"></param>
            public static Byte[] ToBytes(Int32 Value) {
#if UNSAFE
                Byte[] Out = new Byte[sizeof(Int32)];

                unsafe {
                    Byte* s = (Byte*)&Value;

                    Out[0] = *s;
                    Out[1] = *(s + 1);
                    Out[2] = *(s + 2);
                    Out[3] = *(s + 3);
                }
#else
                Int32 Count = sizeof(Int32);
                Byte[] Out = new Byte[Count];

                for (Int32 I = 0; I < Count; I++) {
                    Out[I] = (Byte)(Value & BitConverter._ByteOnlyMask);
                    Value >>= 8;
                }
#endif

                return Out;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Value"></param>
            public static Byte[] ToBytes(Int64 Value) {
#if UNSAFE
                Byte[] Out = new Byte[sizeof(Int64)];

                unsafe {
                    Byte* s = (Byte*)&Value;

                    Out[0] = *s;
                    Out[1] = *(s + 1);
                    Out[2] = *(s + 2);
                    Out[3] = *(s + 3);
                    Out[4] = *(s + 4);
                    Out[5] = *(s + 5);
                    Out[6] = *(s + 6);
                    Out[7] = *(s + 7);
                }
#else
                Int32 Count = sizeof(Int64);
                Byte[] Out = new Byte[Count];

                for (Int32 I = 0; I < Count; I++) {
                    Out[I] = (Byte)(Value & BitConverter._ByteOnlyMask);
                    Value >>= 8;
                }
#endif

                return Out;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Value"></param>
            public static Byte[] ToBytes(UInt16 Value) {
#if UNSAFE
                Byte[] Out = new Byte[sizeof(UInt16)];

                unsafe {
                    Byte* s = (Byte*)&Value;

                    Out[0] = *s;
                    Out[1] = *(s + 1);
                }
#else
                Int32 Count = sizeof(UInt16);
                Byte[] Out = new Byte[Count];

                for (Int32 I = 0; I < Count; I++) {
                    Out[I] = (Byte)(Value & BitConverter._ByteOnlyMask);
                    Value >>= 8;
                }
#endif

                return Out;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Value"></param>
            public static Byte[] ToBytes(UInt32 Value) {
#if UNSAFE
                Byte[] Out = new Byte[sizeof(UInt32)];

                unsafe {
                    Byte* s = (Byte*)&Value;

                    Out[0] = *s;
                    Out[1] = *(s + 1);
                    Out[2] = *(s + 2);
                    Out[3] = *(s + 3);
                }
#else
                Int32 Count = sizeof(UInt32);
                Byte[] Out = new Byte[Count];

                for (Int32 I = 0; I < Count; I++) {
                    Out[I] = (Byte)(Value & BitConverter._ByteOnlyMask);
                    Value >>= 8;
                }
#endif

                return Out;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Value"></param>
            public static Byte[] ToBytes(UInt64 Value) {
#if UNSAFE
                Byte[] Out = new Byte[sizeof(UInt64)];

                unsafe {
                    Byte* s = (Byte*)&Value;

                    Out[0] = *s;
                    Out[1] = *(s + 1);
                    Out[2] = *(s + 2);
                    Out[3] = *(s + 3);
                    Out[4] = *(s + 4);
                    Out[5] = *(s + 5);
                    Out[6] = *(s + 6);
                    Out[7] = *(s + 7);
                }
#else
                Int32 Count = sizeof(UInt64);
                Byte[] Out = new Byte[Count];

                for (Int32 I = 0; I < Count; I++) {
                    Out[I] = (Byte)(Value & BitConverter._ByteOnlyMask);
                    Value >>= 8;
                }
#endif

                return Out;
            }
        }
    }
}
