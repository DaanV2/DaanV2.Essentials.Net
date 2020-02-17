using System;
using System.IO;

namespace DaanV2.IO {
    public static partial class StreamExtension {
        /// <summary>Writes an varint to stream, returns the amount of bytes written</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Value">The variable to write into the stream</param>
        /// <returns>Writes an varint from stream, returns the amount of bytes written</returns>
        public static Int32 Varint_Write(this Stream stream, Int32 Value) {
            return Binary.BitConverter.Varint.Write(stream, Value);
        }

        /// <summary>Writes an varint from stream, returns the amount of bytes written</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Value">The variable to write into the stream</param>
        /// <returns>Writes an varint from stream, returns the amount of bytes written</returns>
        public static Int32 Varint_Write(this Stream stream, Int64 Value) {
            return Binary.BitConverter.Varint.Write(stream, Value);
        }
    }
}
