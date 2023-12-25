﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace DaanV2.IO {
    public static partial class StreamExtension {
        /// <summary>Writes an <see cref="Int16"/> to stream using little endian encoding</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Value">The value to write to stream</param>
        public static void LittleEndianWrite([NotNull] this Stream stream, Int16 Value) {
            Span<Byte> Span = stackalloc Byte[sizeof(Int16)];
            Binary.BitConverter.LittleEndian.OntoBytes(Span, Value);
            stream.Write(Span);
        }

        /// <summary>Writes an <see cref="Int32"/> to stream using little endian encoding</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Value">The value to write to stream</param>
        public static void LittleEndianWrite([NotNull] this Stream stream, Int32 Value) {
            Span<Byte> Span = stackalloc Byte[sizeof(Int32)];
            Binary.BitConverter.LittleEndian.OntoBytes(Span, Value);
            stream.Write(Span);
        }

        /// <summary>Writes an <see cref="Int64"/> to stream using little endian encoding</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Value">The value to write to stream</param>
        public static void LittleEndianWrite([NotNull] this Stream stream, Int64 Value) {
            Span<Byte> Span = stackalloc Byte[sizeof(Int64)];
            Binary.BitConverter.LittleEndian.OntoBytes(Span, Value);
            stream.Write(Span);
        }

        /// <summary>Writes an <see cref="UInt16"/> to stream using little endian encoding</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Value">The value to write to stream</param>
        public static void LittleEndianWrite([NotNull] this Stream stream, UInt16 Value) {
            Span<Byte> Span = stackalloc Byte[sizeof(UInt16)];
            Binary.BitConverter.LittleEndian.OntoBytes(Span, Value);
            stream.Write(Span);
        }

        /// <summary>Writes an <see cref="UInt32"/> to stream using little endian encoding</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Value">The value to write to stream</param>
        public static void LittleEndianWrite([NotNull] this Stream stream, UInt32 Value) {
            Span<Byte> Span = stackalloc Byte[sizeof(UInt32)];
            Binary.BitConverter.LittleEndian.OntoBytes(Span, Value);
            stream.Write(Span);
        }

        /// <summary>Writes an <see cref="UInt64"/> to stream using little endian encoding</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Value">The value to write to stream</param>
        public static void LittleEndianWrite([NotNull] this Stream stream, UInt64 Value) {
            Span<Byte> Span = stackalloc Byte[sizeof(UInt64)];
            Binary.BitConverter.LittleEndian.OntoBytes(Span, Value);
            stream.Write(Span);
        }
    }
}