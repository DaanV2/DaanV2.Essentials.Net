using System;

namespace DaanV2.IO {
    public partial class LittleEndianWriter : IEndianWriter {
        /// <inheritdoc/>
        public void Write(Int16 Value) {
            Span<Byte> Span = stackalloc Byte[sizeof(Int16)];
            Binary.BitConverter.BigEndian.OntoBytes(Span, Value);
            this.Write(Span);
        }

        /// <inheritdoc/>
        public void Write(Int32 Value) {
            Span<Byte> Span = stackalloc Byte[sizeof(Int32)];
            Binary.BitConverter.BigEndian.OntoBytes(Span, Value);
            this.Write(Span);
        }

        /// <inheritdoc/>
        public void Write(Int64 Value) {
            Span<Byte> Span = stackalloc Byte[sizeof(Int64)];
            Binary.BitConverter.BigEndian.OntoBytes(Span, Value);
            this.Write(Span);
        }

        /// <inheritdoc/>
        public void Write(UInt16 Value) {
            Span<Byte> Span = stackalloc Byte[sizeof(UInt16)];
            Binary.BitConverter.BigEndian.OntoBytes(Span, Value);
            this.Write(Span);
        }

        /// <inheritdoc/>
        public void Write(UInt32 Value) {
            Span<Byte> Span = stackalloc Byte[sizeof(UInt32)];
            Binary.BitConverter.BigEndian.OntoBytes(Span, Value);
            this.Write(Span);
        }

        /// <inheritdoc/>
        public void Write(UInt64 Value) {
            Span<Byte> Span = stackalloc Byte[sizeof(UInt64)];
            Binary.BitConverter.BigEndian.OntoBytes(Span, Value);
            this.Write(Span);
        }
    }
}