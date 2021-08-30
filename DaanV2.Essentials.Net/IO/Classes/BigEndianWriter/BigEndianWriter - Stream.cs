using System;
using System.IO;

namespace DaanV2.IO {
    public partial class BigEndianWriter {
        /// <summary>Gets a value indicating whether the current stream supports reading.</summary>
        public override Boolean CanRead => this._BaseStream.CanRead;

        /// <summary>Gets a value indicating whether the current stream supports seeking.</summary>
        public override Boolean CanSeek => this._BaseStream.CanSeek;

        /// <summary>Gets a value indicating whether the current stream supports Writing.</summary>
        public override Boolean CanWrite => this._BaseStream.CanWrite;

        /// <summary>Gets the length in bytes of the stream.</summary>
        public override Int64 Length => this._BaseStream.Length;

        /// <summary>Gets or sets the position within the current stream.</summary>
        public override Int64 Position { get => this._BaseStream.Position; set => this._BaseStream.Position = value; }

        /// <summary>When overridden in a derived class, clears all buffers for this stream and causes any buffered data to be written to the underlying device.</summary>
        /// <exception cref="System.IO.IOException">An I/O error occurs</exception>
        public override void Flush() {
            this._BaseStream.Flush();
        }

        /// <summary>When overridden in a derived class, reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read. </summary>
        /// <param name="buffer">An array of bytes. When this method returns, the buffer contains the specified byte array with the values between offset and (offset + count - 1) replaced by the bytes read from the current source.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin storing the data read from the current stream.</param>
        /// <param name="count">The maximum number of bytes to be read from the current stream.</param>
        /// <returns>The total number of bytes read into the buffer. This can be less than the number of bytes requested if that many bytes are not currently available, or zero (0) if the end of the stream has been reached.</returns>
        /// <exception cref="System.ArgumentException">The sum of offset and count is larger than the buffer length.</exception>
        /// <exception cref="System.ArgumentNullException">buffer is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">offset or count is negative.</exception>
        /// <exception cref="System.IO.IOException">An I/O error occurs.</exception>
        /// <exception cref="System.NotSupportedException">The stream does not support reading.</exception>
        /// <exception cref="System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
        public override Int32 Read(Byte[] buffer, Int32 offset, Int32 count) {
            return this._BaseStream.Read(buffer, offset, count);
        }

        /// <summary>When overridden in a derived class, sets the position within the current stream.</summary>
        /// <param name="offset">A byte offset relative to the origin parameter.</param>
        /// <param name="origin">A value of type System.IO.SeekOrigin indicating the reference point used to obtain the new position.</param>
        /// <returns>The new position within the current stream.</returns>
        /// <exception cref="System.IO.IOException">An I/O error occurs.</exception>
        /// <exception cref="System.NotSupportedException">he stream does not support seeking, such as if the stream is constructed from a pipe or console output.</exception>
        /// <exception cref="System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
        public override Int64 Seek(Int64 offset, SeekOrigin origin) {
            return this._BaseStream.Seek(offset, origin);
        }

        /// <summary>When overridden in a derived class, sets the length of the current stream.</summary>
        /// <param name="value">The desired length of the current stream in bytes.</param>
        /// <exception cref="System.IO.IOException">An I/O error occurs.</exception>
        /// <exception cref="System.NotSupportedException">The stream does not support both writing and seeking, such as if the stream is constructed from a pipe or console output.</exception>
        /// <exception cref="System.ObjectDisposedException">Methods were called after the stream was closed.</exception>
        public override void SetLength(Int64 value) {
            this._BaseStream.SetLength(value);
        }

        /// <summary>When overridden in a derived class, writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written.</summary>
        /// <param name="buffer">An array of bytes. This method copies count bytes from buffer to the current stream.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin copying bytes to the current stream.</param>
        /// <param name="count">The number of bytes to be written to the current stream.</param>
        /// <exception cref="System.ArgumentException">The sum of offset and count is greater than the buffer length.</exception>
        /// <exception cref="System.ArgumentNullException">buffer is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">offset or count is negative.</exception>
        /// <exception cref="System.IO.IOException">An I/O error occurred, such as the specified file cannot be found.</exception>
        /// <exception cref="System.NotSupportedException">The stream does not support writing.</exception>
        /// <exception cref="System.ObjectDisposedException">System.IO.Stream.Write(System.Byte[],System.Int32,System.Int32) was called after the stream was closed.</exception>
        public override void Write(Byte[] buffer, Int32 offset, Int32 count) {
            this._BaseStream.Write(buffer, offset, count);
        }

        /// <summary>When overridden in a derived class, writes a sequence of bytes to the current stream and advances the current position within this stream by the number of bytes written.</summary>
        /// <param name="buffer">An array of bytes. This method copies count bytes from buffer to the current stream.</param>
        /// <exception cref="System.ArgumentException">The sum of offset and count is greater than the buffer length.</exception>
        /// <exception cref="System.ArgumentNullException">buffer is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">offset or count is negative.</exception>
        /// <exception cref="System.IO.IOException">An I/O error occurred, such as the specified file cannot be found.</exception>
        /// <exception cref="System.NotSupportedException">The stream does not support writing.</exception>
        /// <exception cref="System.ObjectDisposedException">System.IO.Stream.Write(System.Byte[],System.Int32,System.Int32) was called after the stream was closed.</exception>
        public override void Write(ReadOnlySpan<Byte> buffer) {
            this._BaseStream.Write(buffer);
        }
    }
}
