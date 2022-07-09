using System;

namespace DaanV2.IO {
    public partial class BigEndianWriter : IEndianWriter {
        /// <summary>Writes an <see cref="Int16"/> to stream using big endian encoding</summary>        
        /// <param name="Value">The value to write to stream</param>
        public void Write(Int16 Value) {
            Span<Byte> Span = this.Int16Buffer();
            Binary.BitConverter.BigEndian.OntoBytes(Span, Value);
            this.Write(Span);
        }

        /// <summary>Writes an <see cref="Int32"/> to stream using big endian encoding</summary>        
        /// <param name="Value">The value to write to stream</param>
        public void Write(Int32 Value) {
            Span<Byte> Span = this.Int32Buffer();
            Binary.BitConverter.BigEndian.OntoBytes(Span, Value);
            this.Write(Span);
        }

        /// <summary>Writes an <see cref="Int64"/> to stream using big endian encoding</summary>        
        /// <param name="Value">The value to write to stream</param>
        public void Write(Int64 Value) {
            Span<Byte> Span = this.Int64Buffer();
            Binary.BitConverter.BigEndian.OntoBytes(Span, Value);
            this.Write(Span);
        }

        /// <summary>Writes an <see cref="UInt16"/> to stream using big endian encoding</summary>        
        /// <param name="Value">The value to write to stream</param>
        public void Write(UInt16 Value) {
            Span<Byte> Span = this.UInt16Buffer();
            Binary.BitConverter.BigEndian.OntoBytes(Span, Value);
            this.Write(Span);
        }

        /// <summary>Writes an <see cref="UInt32"/> to stream using big endian encoding</summary>        
        /// <param name="Value">The value to write to stream</param>
        public void Write(UInt32 Value) {
            Span<Byte> Span = this.UInt32Buffer();
            Binary.BitConverter.BigEndian.OntoBytes(Span, Value);
            this.Write(Span);
        }

        /// <summary>Writes an <see cref="UInt64"/> to stream using big endian encoding</summary>        
        /// <param name="Value">The value to write to stream</param>
        public void Write(UInt64 Value) {
            Span<Byte> Span = this.UInt64Buffer();
            Binary.BitConverter.BigEndian.OntoBytes(Span, Value);
            this.Write(Span);
        }
    }
}