using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace DaanV2.IO {
    public static partial class StreamExtension {
        /// <summary>Reads an <see cref="Int16"/> from stream using little endian encoding</summary>
        /// <param name="stream">The stream to read from</param>
        /// <returns>Reads an <see cref="Int16"/> from stream using little endian encoding</returns>
        public static Int16 LittleEndianReadInt16([NotNull] this Stream stream) {
            Span<Byte> Data = stackalloc Byte[sizeof(Int16)];
            stream.Read(Data);
            return Binary.BitConverter.LittleEndian.ToInt16(Data);
        }

        /// <summary>Reads an <see cref="Int32"/> from stream using little endian encoding</summary>
        /// <param name="stream">The stream to read from</param>
        /// <returns>Reads an <see cref="Int32"/> from stream using little endian encoding</returns>
        public static Int32 LittleEndianReadInt32([NotNull] this Stream stream) {
            Span<Byte> Data = stackalloc Byte[sizeof(Int32)];
            stream.Read(Data);
            return Binary.BitConverter.LittleEndian.ToInt32(Data);
        }

        /// <summary>Reads an <see cref="Int64"/> from stream using little endian encoding</summary>
        /// <param name="stream">The stream to read from</param>
        /// <returns>Reads an <see cref="Int64"/> from stream using little endian encoding</returns>
        public static Int64 LittleEndianReadInt64([NotNull] this Stream stream) {
            Span<Byte> Data = stackalloc Byte[sizeof(Int64)];
            stream.Read(Data);
            return Binary.BitConverter.LittleEndian.ToInt64(Data);
        }

        /// <summary>Reads an <see cref="UInt16"/> from stream using little endian encoding</summary>
        /// <param name="stream">The stream to read from</param>
        /// <returns>Reads an <see cref="UInt16"/> from stream using little endian encoding</returns>
        public static UInt16 LittleEndianReadUInt16([NotNull] this Stream stream) {
            Span<Byte> Data = stackalloc Byte[sizeof(UInt16)];
            stream.Read(Data);
            return Binary.BitConverter.LittleEndian.ToUInt16(Data);
        }

        /// <summary>Reads an <see cref="UInt32"/> from stream using little endian encoding</summary>
        /// <param name="stream">The stream to read from</param>
        /// <returns>Reads an <see cref="UInt32"/> from stream using little endian encoding</returns>
        public static UInt32 LittleEndianReadUInt32([NotNull] this Stream stream) {
            Span<Byte> Data = stackalloc Byte[sizeof(UInt32)];
            stream.Read(Data);
            return Binary.BitConverter.LittleEndian.ToUInt32(Data);
        }

        /// <summary>Reads an <see cref="UInt64"/> from stream using little endian encoding</summary>
        /// <param name="stream">The stream to read from</param>
        /// <returns>Reads an <see cref="UInt64"/> from stream using little endian encoding</returns>
        public static UInt64 LittleEndianReadUInt64([NotNull] this Stream stream) {
            Span<Byte> Data = stackalloc Byte[sizeof(UInt64)];
            stream.Read(Data);
            return Binary.BitConverter.LittleEndian.ToUInt64(Data);
        }
    }
}