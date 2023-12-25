using System.IO;
using DaanV2.Binary;

namespace DaanV2.IO {
    ///DOLATER <summary>add description for class: EndianStreams</summary>
    public static partial class EndianStreams {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Base"></param>
        /// <param name="endianess"></param>
        /// <returns></returns>
        public static IEndianReader? CreateReader(Stream Base, Endianness endianess) {
            return endianess switch {
                Endianness.BigEndian => new BigEndianReader(Base),
                Endianness.LittleEndian => new LittleEndianReader(Base),
                _ => null,
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Base"></param>
        /// <param name="endianess"></param>
        /// <returns></returns>
        public static IEndianWriter? CreateWriter(Stream Base, Endianness endianess) {
            return endianess switch {
                Endianness.BigEndian => new BigEndianWriter(Base),
                Endianness.LittleEndian => new LittleEndianWriter(Base),
                _ => null,
            };
        }
    }
}