/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;

namespace DaanV2.Binary {

    public static partial class BitConverter {
        public static partial class BigEndian {
            /// <summary>Converts the given byte array to an <see cref="Int16"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <returns>Converts the given byte array to an <see cref="Int16"/></returns>
            public static Int16 ToInt16(Byte[] Data) {
                return ToInt16(Data, 0);
            }

            /// <summary>Converts the given byte array to an <see cref="Int16"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given byte array to an <see cref="Int16"/></returns>
            public static Int16 ToInt16(Byte[] Data, Int32 StartIndex) {
                return ToInt16(Data.AsSpan(StartIndex, sizeof(Int16)));
            }

            /// <summary>Converts the given byte array to an <see cref="Int16"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <returns>Converts the given byte array to an <see cref="Int16"/></returns>
            public static Int16 ToInt16(ReadOnlySpan<Byte> Data) {
                return (Int16)ToUInt16(Data);
            }

            /// <summary>Converts the given byte array to an <see cref="Int32"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <returns>Converts the given byte array to an <see cref="Int32"/></returns>
            public static Int32 ToInt32(Byte[] Data) {
                return ToInt32(Data, 0);
            }

            /// <summary>Converts the given byte array to an <see cref="Int32"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given byte array to an <see cref="Int32"/></returns>
            public static Int32 ToInt32(Byte[] Data, Int32 StartIndex) {
                return ToInt32(Data.AsSpan(StartIndex, sizeof(Int32)));
            }

            /// <summary>Converts the given byte array to an <see cref="Int32"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <returns>Converts the given byte array to an <see cref="Int32"/></returns>
            public static Int32 ToInt32(ReadOnlySpan<Byte> Data) {
                return (Int32)ToUInt32(Data);
            }

            /// <summary>Converts the given byte array to an <see cref="Int64"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <returns>Converts the given byte array to an <see cref="Int64"/></returns>
            public static Int64 ToInt64(Byte[] Data) {
                return ToInt64(Data, 0);
            }

            /// <summary>Converts the given byte array to an <see cref="Int64"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given byte array to an <see cref="Int64"/></returns>
            public static Int64 ToInt64(Byte[] Data, Int32 StartIndex) {
                return ToInt64(Data.AsSpan(StartIndex, sizeof(Int64)));
            }

            /// <summary>Converts the given byte array to an <see cref="Int64"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <returns>Converts the given byte array to an <see cref="Int64"/></returns>
            public static Int64 ToInt64(ReadOnlySpan<Byte> Data) {
                return (Int64)ToUInt64(Data);
            }
        }
    }
}
