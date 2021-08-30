using System;

namespace DaanV2.IO {
    public partial class BigEndianReader : IEndianReader {
        /// <summary>Reads an <see cref="Int16"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="Int16"/> from stream using little endian encoding</returns>
        public Int16 ReadInt16() {
            Span<Byte> Span = this.Int16Buffer();
            this._BaseStream.Read(Span);
            return Binary.BitConverter.BigEndian.ToInt16(Span);
        }

        /// <summary>Reads an <see cref="Int32"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="Int32"/> from stream using little endian encoding</returns>
        public Int32 ReadInt32() {
            Span<Byte> Span = this.Int32Buffer();
            this._BaseStream.Read(Span);
            return Binary.BitConverter.BigEndian.ToInt32(Span);
        }

        /// <summary>Reads an <see cref="Int64"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="Int64"/> from stream using little endian encoding</returns>
        public Int64 ReadInt64() {
            Span<Byte> Span = this.Int64Buffer();
            this._BaseStream.Read(Span);
            return Binary.BitConverter.BigEndian.ToInt64(Span);
        }

        /// <summary>Reads an <see cref="UInt16"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="UInt16"/> from stream using little endian encoding</returns>
        public UInt16 ReadUInt16() {
            Span<Byte> Span = this.UInt16Buffer();
            this._BaseStream.Read(Span);
            return Binary.BitConverter.BigEndian.ToUInt16(Span);
        }

        /// <summary>Reads an <see cref="UInt32"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="UInt32"/> from stream using little endian encoding</returns>
        public UInt32 ReadUInt32() {
            Span<Byte> Span = this.UInt32Buffer();
            this._BaseStream.Read(Span);
            return Binary.BitConverter.BigEndian.ToUInt32(Span);
        }

        /// <summary>Reads an <see cref="UInt64"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="UInt64"/> from stream using little endian encoding</returns>
        public UInt64 ReadUInt64() {
            Span<Byte> Span = this.UInt64Buffer();
            this._BaseStream.Read(Span);
            return Binary.BitConverter.BigEndian.ToUInt64(Span);
        }
    }
}
