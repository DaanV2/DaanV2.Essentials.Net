using System;
using System.IO;

namespace DaanV2.IO {
    public static partial class StreamExtension {
        /// <summary>Writes an <see cref="Int16"/> to stream using little endian encoding</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Value">The value to write to stream</param>
        public static void LittleEndian_Write(this Stream stream, Int16 Value) {
            Byte[] Data = Binary.BitConverter.LittleEndian.ToBytes(Value);
            stream.Write(Data, 0, Data.Length);
        }

        /// <summary>Writes an <see cref="Int32"/> to stream using little endian encoding</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Value">The value to write to stream</param>
        public static void LittleEndian_Write(this Stream stream, Int32 Value) {
            Byte[] Data = Binary.BitConverter.LittleEndian.ToBytes(Value);
            stream.Write(Data, 0, Data.Length);
        }

        /// <summary>Writes an <see cref="Int64"/> to stream using little endian encoding</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Value">The value to write to stream</param>
        public static void LittleEndian_Write(this Stream stream, Int64 Value) {
            Byte[] Data = Binary.BitConverter.LittleEndian.ToBytes(Value);
            stream.Write(Data, 0, Data.Length);
        }

        /// <summary>Writes an <see cref="UInt16"/> to stream using little endian encoding</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Value">The value to write to stream</param>
        public static void LittleEndian_Write(this Stream stream, UInt16 Value) {
            Byte[] Data = Binary.BitConverter.LittleEndian.ToBytes(Value);
            stream.Write(Data, 0, Data.Length);
        }

        /// <summary>Writes an <see cref="UInt32"/> to stream using little endian encoding</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Value">The value to write to stream</param>
        public static void LittleEndian_Write(this Stream stream, UInt32 Value) {
            Byte[] Data = Binary.BitConverter.LittleEndian.ToBytes(Value);
            stream.Write(Data, 0, Data.Length);
        }

        /// <summary>Writes an <see cref="UInt64"/> to stream using little endian encoding</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Value">The value to write to stream</param>
        public static void LittleEndian_Write(this Stream stream, UInt64 Value) {
            Byte[] Data = Binary.BitConverter.LittleEndian.ToBytes(Value);
            stream.Write(Data, 0, Data.Length);
        }
    }
}