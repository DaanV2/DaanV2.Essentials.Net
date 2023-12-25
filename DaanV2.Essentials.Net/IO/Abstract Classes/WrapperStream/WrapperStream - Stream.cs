using System;
using System.IO;

namespace DaanV2.IO {
    public abstract partial class WrapperStream {
        /// <inheritdoc/>
        public override Boolean CanRead => this._BaseStream.CanRead;

        /// <inheritdoc/>
        public override Boolean CanSeek => this._BaseStream.CanSeek;

        /// <inheritdoc/>
        public override Boolean CanWrite => this._BaseStream.CanWrite;

        /// <inheritdoc/>
        public override Int64 Length => this._BaseStream.Length;

        /// <inheritdoc/>
        public override Int64 Position { get => this._BaseStream.Position; set => this._BaseStream.Position = value; }

        /// <inheritdoc/>
        public override void Flush() {
            this._BaseStream.Flush();
        }

        /// <inheritdoc/>
        public override Int32 Read(Byte[] buffer, Int32 offset, Int32 count) {
            return this._BaseStream.Read(buffer, offset, count);
        }

        /// <inheritdoc/>
        public override Int64 Seek(Int64 offset, SeekOrigin origin) {
            return this._BaseStream.Seek(offset, origin);
        }

        /// <inheritdoc/>
        public override void SetLength(Int64 value) {
            this._BaseStream.SetLength(value);
        }

        /// <inheritdoc/>
        public override void Write(Byte[] buffer, Int32 offset, Int32 count) {
            this._BaseStream.Write(buffer, offset, count);
        }
    }
}