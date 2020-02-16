﻿using System;

namespace DaanV2.Binary {
    ///DOLATER <summary>add description for class: BitConverter</summary>
    public static partial class BitConverter {
        public static partial class LittleEndian {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="Data"></param>
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

                    *d = Data[0];
                    *(d + 1) = Data[1];
                }
#else
                Out = Data[0];
                Out |= (Int16)(Data[1] << 8);
#endif

                return Out;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Data"></param>
            /// <param name="StartIndex"></param>
            public static Int16 ToInt16(Byte[] Data, Int32 StartIndex) {
                Int16 Out;

                if (Data == null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                if (Data.Length < sizeof(Int16) + StartIndex) {
                    throw new ArgumentException($"{nameof(Data)} is not of appropriate length atleast");
                }

#if UNSAFE
                unsafe {                    
                    Byte* d = (Byte*)&Out;

                    *d = Data[StartIndex];
                    *(d + 1) = Data[1 + StartIndex];
                }
#else
                Out = Data[StartIndex];
                Out |= (Int16)(Data[1 + StartIndex] << 8);
#endif

                return Out;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Data"></param>
            public static Int32 ToInt32(Byte[] Data) {
                Int32 Out;

                if (Data == null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                if (Data.Length < sizeof(Int32)) {
                    throw new ArgumentException($"{nameof(Data)} is not of appropriate length atleast");
                }

#if UNSAFE
                unsafe {                    
                    Byte* d = (Byte*)&Out;

                    *d = Data[0];
                    *(d + 1) = Data[1];
                    *(d + 2) = Data[2];
                    *(d + 3) = Data[3];
                }
#else
                Out = Data[0];
                Out |= Data[1] << 8;
                Out |= Data[2] << 16;
                Out |= Data[3] << 24;
#endif

                return Out;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Data"></param>
            /// <param name="StartIndex"></param>
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

                    *d = Data[StartIndex];
                    *(d + 1) = Data[1 + StartIndex];
                    *(d + 2) = Data[2 + StartIndex];
                    *(d + 3) = Data[3 + StartIndex];
                }
#else
                Out = Data[StartIndex];
                Out |= Data[1 + StartIndex] << 8;
                Out |= Data[2 + StartIndex] << 16;
                Out |= Data[3 + StartIndex] << 24;
#endif

                return Out;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Data"></param>
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

                    *d = Data[0];
                    *(d + 1) = Data[1];
                    *(d + 2) = Data[2];
                    *(d + 3) = Data[3];
                    *(d + 4) = Data[4];
                    *(d + 5) = Data[5];
                    *(d + 6) = Data[6];
                    *(d + 7) = Data[7];
                }
#else
                Out = Data[0];
                Out |= ((Int64)Data[1] << 8);
                Out |= ((Int64)Data[2] << 16);
                Out |= ((Int64)Data[3] << 24);
                Out |= ((Int64)Data[4] << 32);
                Out |= ((Int64)Data[5] << 40);
                Out |= ((Int64)Data[6] << 48);
                Out |= ((Int64)Data[7] << 56);
#endif

                return Out;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Data"></param>
            /// <param name="StartIndex"></param>
            public static Int64 ToInt64(Byte[] Data, Int32 StartIndex) {
                Int64 Out;

                if (Data == null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                if (Data.Length < sizeof(Int64) + StartIndex) {
                    throw new ArgumentException($"{nameof(Data)} is not of appropriate length atleast");
                }

#if UNSAFE
                unsafe {                    
                    Byte* d = (Byte*)&Out;

                    *d = Data[StartIndex];
                    *(d + 1) = Data[1 + StartIndex];
                    *(d + 2) = Data[2 + StartIndex];
                    *(d + 3) = Data[3 + StartIndex];
                    *(d + 4) = Data[4 + StartIndex];
                    *(d + 5) = Data[5 + StartIndex];
                    *(d + 6) = Data[6 + StartIndex];
                    *(d + 7) = Data[7 + StartIndex];
                }
#else
                Out = Data[StartIndex];
                Out |= ((Int64)Data[1 + StartIndex] << 8);
                Out |= ((Int64)Data[2 + StartIndex] << 16);
                Out |= ((Int64)Data[3 + StartIndex] << 24);
                Out |= ((Int64)Data[4 + StartIndex] << 32);
                Out |= ((Int64)Data[5 + StartIndex] << 40);
                Out |= ((Int64)Data[6 + StartIndex] << 48);
                Out |= ((Int64)Data[7 + StartIndex] << 56);
#endif

                return Out;
            }
        }
    }
}
