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
        public static Int16 LittleEndian_ReadInt16(this Stream stream) {
            Byte[] Data = new Byte[sizeof(Int16)];
            stream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.LittleEndian.ToInt16(Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Int32 LittleEndian_ReadInt32(this Stream stream) {
            Byte[] Data = new Byte[sizeof(Int32)];
            stream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.LittleEndian.ToInt32(Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Int64 LittleEndian_ReadInt64(this Stream stream) {
            Byte[] Data = new Byte[sizeof(Int64)];
            stream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.LittleEndian.ToInt64(Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static UInt16 LittleEndian_ReadUInt16(this Stream stream) {
            Byte[] Data = new Byte[sizeof(UInt16)];
            stream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.LittleEndian.ToUInt16(Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static UInt32 LittleEndian_ReadUInt32(this Stream stream) {
            Byte[] Data = new Byte[sizeof(UInt32)];
            stream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.LittleEndian.ToUInt32(Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static UInt64 LittleEndian_ReadUInt64(this Stream stream) {
            Byte[] Data = new Byte[sizeof(UInt64)];
            stream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.LittleEndian.ToUInt64(Data);
        }
    }
}
