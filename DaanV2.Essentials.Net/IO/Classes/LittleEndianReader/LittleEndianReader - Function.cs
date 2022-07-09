using System;

namespace DaanV2.IO {
    public partial class LittleEndianReader : IEndianReader {
        /// <summary>Reads an <see cref="Int16"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="Int16"/> from stream using little endian encoding</returns>
        public Int16 ReadInt16() {
            Span<Byte> Span = this.Int16Buffer();
            this._BaseStream.Read(Span);
            return Binary.BitConverter.LittleEndian.ToInt16(this._Buffer);
        }

        /// <summary>Reads an <see cref="Int32"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="Int32"/> from stream using little endian encoding</returns>
        public Int32 ReadInt32() {
            Span<Byte> Span = this.Int32Buffer();
            this._BaseStream.Read(Span);
            return Binary.BitConverter.LittleEndian.ToInt32(this._Buffer);
        }

        /// <summary>Reads an <see cref="Int64"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="Int64"/> from stream using little endian encoding</returns>
        public Int64 ReadInt64() {
            Span<Byte> Span = this.Int64Buffer();
            this._BaseStream.Read(Span);
            return Binary.BitConverter.LittleEndian.ToInt64(this._Buffer);
        }

        /// <summary>Reads an <see cref="UInt16"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="UInt16"/> from stream using little endian encoding</returns>
        public UInt16 ReadUInt16() {
            Span<Byte> Span = this.UInt16Buffer();
            this._BaseStream.Read(Span);
            return Binary.BitConverter.LittleEndian.ToUInt16(this._Buffer);
        }

        /// <summary>Reads an <see cref="UInt32"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="UInt32"/> from stream using little endian encoding</returns>
        public UInt32 ReadUInt32() {
            Span<Byte> Span = this.UInt32Buffer();
            this._BaseStream.Read(Span);
            return Binary.BitConverter.LittleEndian.ToUInt32(this._Buffer);
        }

        /// <summary>Reads an <see cref="UInt64"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="UInt64"/> from stream using little endian encoding</returns>
        public UInt64 ReadUInt64() {
            Span<Byte> Span = this.UInt64Buffer();
            this._BaseStream.Read(Span);
            return Binary.BitConverter.LittleEndian.ToUInt64(this._Buffer);
        }
    }
}