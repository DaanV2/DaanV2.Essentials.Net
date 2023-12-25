using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace DaanV2.IO {
    public static partial class StreamExtension {
        /// <summary>Reads an <see cref="Int16"/> from stream using big endian encoding</summary>
        /// <param name="stream">The stream to read from</param>
        /// <returns>Reads an <see cref="Int16"/> from stream using big endian encoding</returns>
        public static Int16 BigEndianReadInt16([NotNull] this Stream stream) {
            Span<Byte> Data = stackalloc Byte[sizeof(Int16)];
            stream.Read(Data);
            return Binary.BitConverter.BigEndian.ToInt16(Data);
        }

        /// <summary>Reads an <see cref="Int32"/> from stream using big endian encoding</summary>
        /// <param name="stream">The stream to read from</param>
        /// <returns>Reads an <see cref="Int32"/> from stream using big endian encoding</returns>
        public static Int32 BigEndianReadInt32([NotNull] this Stream stream) {
            Span<Byte> Data = stackalloc Byte[sizeof(Int32)];
            stream.Read(Data);
            return Binary.BitConverter.BigEndian.ToInt32(Data);
        }

        /// <summary>Reads an <see cref="Int64"/> from stream using big endian encoding</summary>
        /// <param name="stream">The stream to read from</param>
        /// <returns>Reads an <see cref="Int64"/> from stream using big endian encoding</returns>
        public static Int64 BigEndianReadInt64([NotNull] this Stream stream) {
            Span<Byte> Data = stackalloc Byte[sizeof(Int64)];
            stream.Read(Data);
            return Binary.BitConverter.BigEndian.ToInt64(Data);
        }

        /// <summary>Reads an <see cref="UInt16"/> from stream using big endian encoding</summary>
        /// <param name="stream">The stream to read from</param>
        /// <returns>Reads an <see cref="UInt16"/> from stream using big endian encoding</returns>
        public static UInt16 BigEndianReadUInt16([NotNull] this Stream stream) {
            Span<Byte> Data = stackalloc Byte[sizeof(UInt16)];
            stream.Read(Data);
            return Binary.BitConverter.BigEndian.ToUInt16(Data);
        }

        /// <summary>Reads an <see cref="UInt32"/> from stream using big endian encoding</summary>
        /// <param name="stream">The stream to read from</param>
        /// <returns>Reads an <see cref="UInt32"/> from stream using big endian encoding</returns>
        public static UInt32 BigEndianReadUInt32([NotNull] this Stream stream) {
            Span<Byte> Data = stackalloc Byte[sizeof(UInt32)];
            stream.Read(Data);
            return Binary.BitConverter.BigEndian.ToUInt32(Data);
        }

        /// <summary>Reads an <see cref="UInt64"/> from stream using big endian encoding</summary>
        /// <param name="stream">The stream to read from</param>
        /// <returns>Reads an <see cref="UInt64"/> from stream using big endian encoding</returns>
        public static UInt64 BigEndianReadUInt64([NotNull] this Stream stream) {
            Span<Byte> Data = stackalloc Byte[sizeof(UInt64)];
            stream.Read(Data);
            return Binary.BitConverter.BigEndian.ToUInt64(Data);
        }
    }
}