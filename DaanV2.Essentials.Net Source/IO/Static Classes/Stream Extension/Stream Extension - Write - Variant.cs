using System;
using System.IO;

namespace DaanV2.IO {
    public static partial class StreamExtension {
        /// <summary>Read an varint from stream into a <see cref="Int32" /></summary>
        /// <param name="stream">The stream to read from</param>
        /// <param name="Value">The variable to write into the stream</param>
        /// <returns>Read an varint from stream into a <see cref="Int32" /></returns>
        public static Int32 Varint_Write(this Stream stream, Int32 Value) {
            return Binary.BitConverter.Varint.Write(stream, Value);
        }

        /// <summary>Read an varint from stream into a <see cref="Int64" /></summary>
        /// <param name="stream">The stream to read from</param>
        /// <param name="Value">The variable to write into the stream</param>
        /// <returns>Read an varint from stream into a <see cref="Int64" /></returns>
        public static Int64 Varint_Write(this Stream stream, Int64 Value) {
            return Binary.BitConverter.Varint.Write(stream, Value);
        }
    }
}
