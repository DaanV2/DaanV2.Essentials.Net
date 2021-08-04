using System.IO;
using DaanV2.Binary;

namespace DaanV2.IO {
    ///DOLATER <summary>add description for class: EndianStream</summary>
    public static partial class EndianStream {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Base"></param>
        /// <param name="endianess"></param>
        /// <returns></returns>
        public static IEndianReader CreateReader(Stream Base, Endianness endianess) {
            switch (endianess) {
                case Endianness.BigEndian:
                    return new BigEndianReader(Base);

                case Endianness.LittleEndian:
                    return new LittleEndianReader(Base);

                default:
                    return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Base"></param>
        /// <param name="endianess"></param>
        /// <returns></returns>
        public static IEndianWriter CreateWriter(Stream Base, Endianness endianess) {
            switch (endianess) {
                case Endianness.BigEndian:
                    return new BigEndianWriter(Base);

                case Endianness.LittleEndian:
                    return new LittleEndianWriter(Base);

                default:
                    return null;
            }
        }
    }
}
