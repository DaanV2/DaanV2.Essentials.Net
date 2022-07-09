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

        /// <summary>Gets a value indicating whether the current stream supports reading.</summary>
        Boolean CanRead { get; }

        /// <summary>Gets a value indicating whether the current stream supports seeking.</summary>
        Boolean CanSeek { get; }

        /// <summary>Gets a value indicating whether the current stream supports Writing.</summary>
        Boolean CanWrite { get; }

        /// <summary>Gets the length in bytes of the stream.</summary>
        Int64 Length { get; }

        /// <summary>Gets or sets the position within the current stream.</summary>
        Int64 Position { get; set; }

        /// <summary>When overridden in a derived class, clears all buffers for this stream and causes any buffered data to be written to the underlying device.</summary>
        void Flush();

        /// <summary>When overridden in a derived class, reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read. </summary>
        /// <param name="buffer">An array of bytes. When this method returns, the buffer contains the specified byte array with the values between offset and (offset + count - 1) replaced by the bytes read from the current source.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin storing the data read from the current stream.</param>
        /// <param name="count">The maximum number of bytes to be read from the current stream.</param>
        /// <returns>The total number of bytes read into the buffer. This can be less than the number of bytes requested if that many bytes are not currently available, or zero (0) if the end of the stream has been reached.</returns>
        Int32 Read(Byte[] buffer, Int32 offset, Int32 count);

        /// <summary>When overridden in a derived class, sets the position within the current stream.</summary>
        /// <param name="offset">A byte offset relative to the origin parameter.</param>
        /// <param name="origin">A value of type System.IO.SeekOrigin indicating the reference point used to obtain the new position.</param>
        /// <returns>The new position within the current stream.</returns>
        Int64 Seek(Int64 offset, SeekOrigin origin);

        /// <summary>When overridden in a derived class, sets the length of the current stream.</summary>
        /// <param name="value">The desired length of the current stream in bytes.</param>
        void SetLength(Int64 value);

        /// <summary>When overridden in a derived class, writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written.</summary>
        /// <param name="buffer">An array of bytes. This method copies count bytes from buffer to the current stream.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin copying bytes to the current stream.</param>
        /// <param name="count">The number of bytes to be written to the current stream.</param>
        void Write(Byte[] buffer, Int32 offset, Int32 count);
    }
}