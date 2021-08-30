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
            public static UInt16 ToUInt16(Byte[] Data, Endianness endianness) {
                return endianness == Endianness.BigEndian ? 
                    BitConverter.BigEndian.ToUInt16(Data) : 
                    BitConverter.LittleEndian.ToUInt16(Data);
            }

            /// <summary>Converts the given byte array into a <see cref="UInt16"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <returns>Converts the given byte array into a <see cref="UInt16"/></returns>
            public static UInt16 ToUInt16(Byte[] Data, Int32 StartIndex, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToUInt16(Data, StartIndex) :
                    BitConverter.LittleEndian.ToUInt16(Data, StartIndex);
            }

            /// <summary>Converts the given byte array into a <see cref="UInt16"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <returns>Converts the given byte array into a <see cref="UInt16"/></returns>
            public static UInt32 ToUInt32(Byte[] Data, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToUInt32(Data) :
                    BitConverter.LittleEndian.ToUInt32(Data);
            }

            /// <summary>Converts the given byte array into a <see cref="UInt32"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <returns>Converts the given byte array into a <see cref="UInt32"/></returns>
            public static UInt32 ToUInt32(Byte[] Data, Int32 StartIndex, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToUInt32(Data, StartIndex) :
                    BitConverter.LittleEndian.ToUInt32(Data, StartIndex);
            }

            /// <summary>Converts the given byte array into a <see cref="UInt16"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <returns>Converts the given byte array into a <see cref="UInt16"/></returns>
            public static UInt64 ToUInt64(Byte[] Data, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToUInt64(Data) :
                    BitConverter.LittleEndian.ToUInt64(Data);
            }

            /// <summary>Converts the given byte array into a <see cref="UInt64"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <param name="endianness">Marks if little or big endian should be used</param>
            /// <returns>Converts the given byte array into a <see cref="UInt64"/></returns>
            public static UInt64 ToUInt64(Byte[] Data, Int32 StartIndex, Endianness endianness) {
                return endianness == Endianness.BigEndian ?
                    BitConverter.BigEndian.ToUInt64(Data, StartIndex) :
                    BitConverter.LittleEndian.ToUInt64(Data, StartIndex);
            }
        }
    }
}
