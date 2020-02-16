using System;
using System.IO;

namespace DaanV2.IO {
    ///DOLATER <summary>add description for class: StreamExtension</summary>
    public static partial class StreamExtension {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Int16 BigEndian_ReadInt16(this Stream stream) {
            Byte[] Data = new Byte[sizeof(Int16)];
            stream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.BigEndian.ToInt16(Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Int32 BigEndian_ReadInt32(this Stream stream) {
            Byte[] Data = new Byte[sizeof(Int32)];
            stream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.BigEndian.ToInt32(Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Int64 BigEndian_ReadInt64(this Stream stream) {
            Byte[] Data = new Byte[sizeof(Int64)];
            stream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.BigEndian.ToInt64(Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static UInt16 BigEndian_ReadUInt16(this Stream stream) {
            Byte[] Data = new Byte[sizeof(UInt16)];
            stream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.BigEndian.ToUInt16(Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static UInt32 BigEndian_ReadUInt32(this Stream stream) {
            Byte[] Data = new Byte[sizeof(UInt32)];
            stream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.BigEndian.ToUInt32(Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static UInt64 BigEndian_ReadUInt64(this Stream stream) {
            Byte[] Data = new Byte[sizeof(UInt64)];
            stream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.BigEndian.ToUInt64(Data);
        }
    }
}
