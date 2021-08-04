using System;
using System.IO;

namespace DaanV2.IO {
    ///DOLATER <summary>add description for interface: IEndianReader</summary>
    public interface IEndianWriter {
        /// <summary>Writes an <see cref="Int16"/> to stream using big endian encoding</summary>
        /// <param name="Value">The value to write to stream</param>
        void Write(Int16 Value);

        /// <summary>Writes an <see cref="Int32"/> to stream using big endian encoding</summary>
        /// <param name="Value">The value to write to stream</param>
        void Write(Int32 Value);

        /// <summary>Writes an <see cref="Int64"/> to stream using big endian encoding</summary>
        /// <param name="Value">The value to write to stream</param>
        void Write(Int64 Value);

        /// <summary>Writes an <see cref="UInt16"/> to stream using big endian encoding</summary>
        /// <param name="Value">The value to write to stream</param>
        void Write(UInt16 Value);

        /// <summary>Writes an <see cref="UInt32"/> to stream using big endian encoding</summary>
        /// <param name="Value">The value to write to stream</param>
        void Write(UInt32 Value);

        /// <summary>Writes an <see cref="UInt64"/> to stream using big endian encoding</summary>
        /// <param name="Value">The value to write to stream</param>
        void Write(UInt64 Value);

        Boolean CanRead { get; }
        Boolean CanSeek { get; }
        Boolean CanWrite { get; }
        Int64 Length { get; }
        Int64 Position { get; set; }
        void Flush();

        Int32 Read(Byte[] buffer, Int32 offset, Int32 count);

        Int64 Seek(Int64 offset, SeekOrigin origin);

        void SetLength(Int64 value);

        void Write(Byte[] buffer, Int32 offset, Int32 count);
    }
}
