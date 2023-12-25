using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace DaanV2.IO {
    public static partial class StreamExtension {
        /// <summary>Read an varint from stream into a <see cref="Int32" /></summary>
        /// <param name="stream">The stream to read from</param>
        /// <param name="Count">The amount of bytes read</param>
        /// <returns>Read an varint from stream into a <see cref="Int32" /></returns>
        public static Int32 VarintReadInt32([NotNull] this Stream stream, out Int32 Count) {
            Int32 Out = Binary.BitConverter.VarInt.ReadInt32(stream, out Int32 bCount);
            Count = bCount;
            return Out;
        }

        /// <summary>Read an varint from stream into a <see cref="Int64" /></summary>
        /// <param name="stream">The stream to read from</param>
        /// <param name="Count">The amount of bytes read</param>
        /// <returns>Read an varint from stream into a <see cref="Int64" /></returns>
        public static Int64 VarintReadInt64([NotNull] this Stream stream, out Int32 Count) {
            Int64 Out = Binary.BitConverter.VarInt.ReadInt64(stream, out Int32 bCount);
            Count = bCount;
            return Out;
        }
    }
}