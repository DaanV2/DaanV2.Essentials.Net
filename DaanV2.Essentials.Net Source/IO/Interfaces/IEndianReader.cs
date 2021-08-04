using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.IO {
    ///DOLATER <summary>add description for interface: IEndianReader</summary>
    public interface IEndianReader {
        /// <summary>Reads an <see cref="Int16"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="Int16"/> from stream using little endian encoding</returns>
        Int16 ReadInt16();

        /// <summary>Reads an <see cref="Int32"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="Int32"/> from stream using little endian encoding</returns>
        Int32 ReadInt32();

        /// <summary>Reads an <see cref="Int64"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="Int64"/> from stream using little endian encoding</returns>
        Int64 ReadInt64();

        /// <summary>Reads an <see cref="UInt16"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="UInt16"/> from stream using little endian encoding</returns>
        UInt16 ReadUInt16();

        /// <summary>Reads an <see cref="UInt32"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="UInt32"/> from stream using little endian encoding</returns>
        UInt32 ReadUInt32();

        /// <summary>Reads an <see cref="UInt64"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="UInt64"/> from stream using little endian encoding</returns>
         UInt64 ReadUInt64();

        Boolean CanRead { get; }
        Boolean CanSeek { get; }
        Boolean CanWrite { get; }
        Int64 Length { get; }
        Int64 Position { get ; set; }
        void Flush();

        Int32 Read(Byte[] buffer, Int32 offset, Int32 count);

        Int64 Seek(Int64 offset, SeekOrigin origin);

        void SetLength(Int64 value);

        void Write(Byte[] buffer, Int32 offset, Int32 count);
    }
}
