using System;
using System.IO;

namespace DaanV2.IO {
    public static partial class StreamExtension {
        /// <summary>Read an varint from stream into a <see cref="Int32" /></summary>
        /// <param name="stream">The stream to read from</param>
        /// <returns>Read an varint from stream into a <see cref="Int32" /></returns>
        public static Int32 Varint_ReadInt32(this Stream stream) {
            return Binary.BitConverter.Varint.ReadInt32(stream, out Int32 Count);
        }

        /// <summary>Read an varint from stream into a <see cref="Int64" /></summary>
        /// <param name="stream">The stream to read from</param>
        /// <returns>Read an varint from stream into a <see cref="Int64" /></returns>
        public static Int64 Varint_ReadInt64(this Stream stream) {
            return Binary.BitConverter.Varint.ReadInt64(stream, out Int32 Count);
        }
    }
}
