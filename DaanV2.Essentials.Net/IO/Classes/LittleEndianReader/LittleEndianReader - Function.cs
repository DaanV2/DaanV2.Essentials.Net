using System;

namespace DaanV2.IO {
    public partial class LittleEndianReader : IEndianReader {
        /// <inheritdoc/>
        public Int16 ReadInt16() {
            Span<Byte> Span = stackalloc Byte[sizeof(Int16)];
            this._BaseStream.Read(Span);
            return Binary.BitConverter.LittleEndian.ToInt16(Span);
        }

        /// <inheritdoc/>
        public Int32 ReadInt32() {
            Span<Byte> Span = stackalloc Byte[sizeof(Int32)];
            this._BaseStream.Read(Span);
            return Binary.BitConverter.LittleEndian.ToInt32(Span);
        }

        /// <inheritdoc/>
        public Int64 ReadInt64() {
            Span<Byte> Span = stackalloc Byte[sizeof(Int64)];
            this._BaseStream.Read(Span);
            return Binary.BitConverter.LittleEndian.ToInt64(Span);
        }

        /// <inheritdoc/>
        public UInt16 ReadUInt16() {
            Span<Byte> Span = stackalloc Byte[sizeof(UInt16)];
            this._BaseStream.Read(Span);
            return Binary.BitConverter.LittleEndian.ToUInt16(Span);
        }

        /// <inheritdoc/>
        public UInt32 ReadUInt32() {
            Span<Byte> Span = stackalloc Byte[sizeof(UInt32)];
            this._BaseStream.Read(Span);
            return Binary.BitConverter.LittleEndian.ToUInt32(Span);
        }

        /// <inheritdoc/>
        public UInt64 ReadUInt64() {
            Span<Byte> Span = stackalloc Byte[sizeof(UInt64)];
            this._BaseStream.Read(Span);
            return Binary.BitConverter.LittleEndian.ToUInt64(Span);
        }
    }
}