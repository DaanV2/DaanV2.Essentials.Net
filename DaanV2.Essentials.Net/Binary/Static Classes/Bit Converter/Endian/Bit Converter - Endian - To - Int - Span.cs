/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;

namespace DaanV2.Binary {

    public static partial class BitConverter {
        public static partial class Endian {
            /// <summary>Converts the given byte array into a <see cref="Int16"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <returns>Converts the given byte array into a <see cref="Int16"/></returns>
            public static void ToInt16(ReadOnlySpan<Byte> Data, Endianness endianness) {
                if (endianness == Endianness.BigEndian)
                    BitConverter.BigEndian.ToInt16(Data);
                else
                    BitConverter.LittleEndian.ToInt16(Data);
            }

            /// <summary>Converts the given byte array into a <see cref="Int32"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <returns>Converts the given byte array into a <see cref="Int32"/></returns>
            public static void ToInt32(ReadOnlySpan<Byte> Data, Endianness endianness) {
                if (endianness == Endianness.BigEndian)
                    BitConverter.BigEndian.ToInt32(Data);
                else
                    BitConverter.LittleEndian.ToInt32(Data);
            }

            /// <summary>Converts the given byte array into a <see cref="Int64"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <returns>Converts the given byte array into a <see cref="Int64"/></returns>
            public static void ToInt64(ReadOnlySpan<Byte> Data, Endianness endianness) {
                if (endianness == Endianness.BigEndian)
                    BitConverter.BigEndian.ToInt64(Data);
                else
                    BitConverter.LittleEndian.ToInt64(Data);
            }
        }
    }
}
