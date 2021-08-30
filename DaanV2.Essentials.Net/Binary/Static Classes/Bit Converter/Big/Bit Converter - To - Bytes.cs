/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Runtime.CompilerServices;

namespace DaanV2.Binary {
    
    public static partial class BitConverter {
        public static partial class BigEndian {
            /// <summary>Converts the specified object into a byte array</summary>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the specified object into a byte array</returns>
            [MethodImpl(MethodImplOptions.AggressiveOptimization)]
            public static Byte[] ToBytes(Int16 Value) {
                Byte[] Out = new Byte[sizeof(Int16)];
                OntoBytes(Out.AsSpan(), Value);

                return Out;
            }

            /// <summary>Converts the specified object into a byte array</summary>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the specified object into a byte array</returns>
            [MethodImpl(MethodImplOptions.AggressiveOptimization)]
            public static Byte[] ToBytes(Int32 Value) {
                Byte[] Out = new Byte[sizeof(Int32)];
                OntoBytes(Out.AsSpan(), Value);

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

                    Out[7] = *s;
                    Out[6] = *(s + 1);
                    Out[5] = *(s + 2);
                    Out[4] = *(s + 3);
                    Out[3] = *(s + 4);
                    Out[2] = *(s + 5);
                    Out[1] = *(s + 6);
                    Out[0] = *(s + 7);
                }
#else
                Int32 Count = sizeof(Int64);
                Byte[] Out = new Byte[Count];

                for (Int32 I = 0; I < Count; I++) {
                    Out[I] = (Byte)(Value);
                    Value >>= 8;
                }

                Array.Reverse(Out);
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

                    Out[1] = *s;
                    Out[0] = *(s + 1);
                }
#else
                Int32 Count = sizeof(UInt16);
                Byte[] Out = new Byte[Count];

                for (Int32 I = 0; I < Count; I++) {
                    Out[I] = (Byte)(Value);
                    Value >>= 8;
                }

                Array.Reverse(Out);
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

                    Out[3] = *s;
                    Out[2] = *(s + 1);
                    Out[1] = *(s + 2);
                    Out[0] = *(s + 3);
                }
#else
                Int32 Count = sizeof(UInt32);
                Byte[] Out = new Byte[Count];

                for (Int32 I = 0; I < Count; I++) {
                    Out[I] = (Byte)(Value);
                    Value >>= 8;
                }

                Array.Reverse(Out);
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

                    Out[7] = *s;
                    Out[6] = *(s + 1);
                    Out[5] = *(s + 2);
                    Out[4] = *(s + 3);
                    Out[3] = *(s + 4);
                    Out[2] = *(s + 5);
                    Out[1] = *(s + 6);
                    Out[0] = *(s + 7);
                }
#else
                Int32 Count = sizeof(UInt64);
                Byte[] Out = new Byte[Count];

                for (Int32 I = 0; I < Count; I++) {
                    Out[I] = (Byte)(Value);
                    Value >>= 8;
                }

                Array.Reverse(Out);
#endif

                return Out;
            }
        }
    }
}
