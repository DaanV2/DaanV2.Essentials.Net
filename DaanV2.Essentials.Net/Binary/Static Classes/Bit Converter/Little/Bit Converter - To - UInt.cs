﻿/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Runtime.CompilerServices;

namespace DaanV2.Binary {
    public static partial class BitConverter {
        public static partial class LittleEndian {
            /// <summary>Converts the given byte array into a <see cref="UInt16"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <returns>Converts the given byte array into a <see cref="UInt16"/></returns>
            public static UInt16 ToUInt16(Byte[] Data) {
                return ToUInt16(Data, 0);
            }

            /// <summary>Converts the given byte array into a <see cref="UInt16"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given byte array into a <see cref="UInt16"/></returns>
            public static UInt16 ToUInt16(Byte[] Data, Int32 StartIndex) {
                return ToUInt16(Data.AsSpan(StartIndex, sizeof(UInt16)));
            }

            /// <summary>Converts the given byte array into a <see cref="UInt16"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <returns>Converts the given byte array into a <see cref="UInt16"/></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static UInt16 ToUInt16(ReadOnlySpan<Byte> Data) {
                UInt16 Out = Data[0];
                Out |= (UInt16)(Data[1] << 8);

                return Out;
            }

            /// <summary>Converts the given byte array into a <see cref="UInt32"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <returns>Converts the given byte array into a <see cref="UInt32"/></returns>
            public static UInt32 ToUInt32(Byte[] Data) {
                return ToUInt32(Data, 0);
            }

            /// <summary>Converts the given byte array into a <see cref="UInt32"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given byte array into a <see cref="UInt32"/></returns>
            public static UInt32 ToUInt32(Byte[] Data, Int32 StartIndex) {
                return ToUInt32(Data.AsSpan(StartIndex, sizeof(UInt32)));
            }

            /// <summary>Converts the given byte array into a <see cref="UInt32"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <returns>Converts the given byte array into a <see cref="UInt32"/></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static UInt32 ToUInt32(ReadOnlySpan<Byte> Data) {
                UInt32 Out = Data[0];
                Out |= (UInt32)Data[1] << 8;
                Out |= (UInt32)Data[2] << 16;
                Out |= (UInt32)Data[3] << 24;

                return Out;
            }

            /// <summary>Converts the given byte array into a <see cref="UInt64"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <returns>Converts the given byte array into a <see cref="UInt64"/></returns>
            public static UInt64 ToUInt64(Byte[] Data) {
                return ToUInt64(Data, 0);
            }

            /// <summary>Converts the given byte array into a <see cref="UInt64"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given byte array into a <see cref="UInt64"/></returns>
            public static UInt64 ToUInt64(Byte[] Data, Int32 StartIndex) {
                return ToUInt64(Data.AsSpan(StartIndex, sizeof(UInt64)));
            }

            /// <summary>Converts the given byte array into a <see cref="UInt64"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <returns>Converts the given byte array into a <see cref="UInt64"/></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static UInt64 ToUInt64(ReadOnlySpan<Byte> Data) {
                UInt64 Out = Data[0];
                Out |= (UInt64)Data[1] << 8;
                Out |= (UInt64)Data[2] << 16;
                Out |= (UInt64)Data[3] << 24;
                Out |= (UInt64)Data[4] << 32;
                Out |= (UInt64)Data[5] << 40;
                Out |= (UInt64)Data[6] << 48;
                Out |= (UInt64)Data[7] << 56;

                return Out;
            }
        }
    }
}