using System;

namespace DaanV2.Binary {

    public static partial class BitConverter {
        public static partial class Endian {
            /// <summary>Converts the given byte array into a <see cref="Int16"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <returns>Converts the given byte array into a <see cref="Int16"/></returns>
            public static Int16 ToInt16(ReadOnlySpan<Byte> Data, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToInt16(Data) :
                    BitConverter.LittleEndian.ToInt16(Data);
            }

            /// <summary>Converts the given byte array into a <see cref="Int32"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <returns>Converts the given byte array into a <see cref="Int32"/></returns>
            public static Int32 ToInt32(ReadOnlySpan<Byte> Data, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToInt32(Data) :
                    BitConverter.LittleEndian.ToInt32(Data);
            }

            /// <summary>Converts the given byte array into a <see cref="Int64"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <returns>Converts the given byte array into a <see cref="Int64"/></returns>
            public static Int64 ToInt64(ReadOnlySpan<Byte> Data, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToInt64(Data) :
                    BitConverter.LittleEndian.ToInt64(Data);
            }
        }
    }
}