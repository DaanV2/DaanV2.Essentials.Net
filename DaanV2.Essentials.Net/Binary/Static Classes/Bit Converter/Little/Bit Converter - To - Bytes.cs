/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;

namespace DaanV2.Binary {
    
    public static partial class BitConverter {
        public static partial class LittleEndian {
            /// <summary>Converts the specified object into a byte array</summary>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the specified object into a byte array</returns>
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
                    Out[I] = (Byte)(Value);
                    Value >>= 8;
                }
#endif

                return Out;
            }

            /// <summary>Converts the specified object into a byte array</summary>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the specified object into a byte array</returns>
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
                    Out[I] = (Byte)(Value);
                    Value >>= 8;
                }
#endif

                return Out;
            }

            /// <summary>Converts the specified object into a byte array</summary>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the specified object into a byte array</returns>
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
                    Out[I] = (Byte)(Value);
                    Value >>= 8;
                }
#endif

                return Out;
            }

            /// <summary>Converts the specified object into a byte array</summary>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the specified object into a byte array</returns>
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
                    Out[I] = (Byte)(Value);
                    Value >>= 8;
                }
#endif

                return Out;
            }

            /// <summary>Converts the specified object into a byte array</summary>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the specified object into a byte array</returns>
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
                    Out[I] = (Byte)(Value);
                    Value >>= 8;
                }
#endif

                return Out;
            }

            /// <summary>Converts the specified object into a byte array</summary>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the specified object into a byte array</returns>
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
                    Out[I] = (Byte)(Value);
                    Value >>= 8;
                }
#endif

                return Out;
            }
        }
    }
}
