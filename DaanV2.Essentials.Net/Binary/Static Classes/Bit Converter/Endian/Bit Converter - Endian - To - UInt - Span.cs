/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;

namespace DaanV2.Binary {

    public static partial class BitConverter {
        public static partial class Endian {
            /// <summary>Converts the given byte array into a <see cref="UInt16"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <returns>Converts the given byte array into a <see cref="UInt16"/></returns>
            public static UInt16 ToUInt16(ReadOnlySpan<Byte> Data, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToUInt16(Data) :
                    BitConverter.LittleEndian.ToUInt16(Data);
            }

            /// <summary>Converts the given byte array into a <see cref="UInt16"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <returns>Converts the given byte array into a <see cref="UInt16"/></returns>
            public static UInt32 ToUInt32(ReadOnlySpan<Byte> Data, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToUInt32(Data) :
                    BitConverter.LittleEndian.ToUInt32(Data);
            }

            /// <summary>Converts the given byte array into a <see cref="UInt16"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <returns>Converts the given byte array into a <see cref="UInt16"/></returns>
            public static UInt64 ToUInt64(ReadOnlySpan<Byte> Data, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToUInt64(Data) :
                    BitConverter.LittleEndian.ToUInt64(Data);
            }
        }
    }
}