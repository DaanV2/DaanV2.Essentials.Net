using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.IO {
    public partial class LittleEndianReader : IEndianReader {
        /// <summary>Reads an <see cref="Int16"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="Int16"/> from stream using little endian encoding</returns>
        public Int16 ReadInt16() {
            Byte[] Data = new Byte[sizeof(Int16)];
            this._BaseStream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.LittleEndian.ToInt16(Data);
        }

        /// <summary>Reads an <see cref="Int32"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="Int32"/> from stream using little endian encoding</returns>
        public Int32 ReadInt32() {
            Byte[] Data = new Byte[sizeof(Int32)];
            this._BaseStream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.LittleEndian.ToInt32(Data);
        }

        /// <summary>Reads an <see cref="Int64"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="Int64"/> from stream using little endian encoding</returns>
        public Int64 ReadInt64() {
            Byte[] Data = new Byte[sizeof(Int64)];
            this._BaseStream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.LittleEndian.ToInt64(Data);
        }

        /// <summary>Reads an <see cref="UInt16"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="UInt16"/> from stream using little endian encoding</returns>
        public UInt16 ReadUInt16() {
            Byte[] Data = new Byte[sizeof(UInt16)];
            this._BaseStream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.LittleEndian.ToUInt16(Data);
        }

        /// <summary>Reads an <see cref="UInt32"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="UInt32"/> from stream using little endian encoding</returns>
        public UInt32 ReadUInt32() {
            Byte[] Data = new Byte[sizeof(UInt32)];
            this._BaseStream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.LittleEndian.ToUInt32(Data);
        }

        /// <summary>Reads an <see cref="UInt64"/> from stream using little endian encoding</summary>        
        /// <returns>Reads an <see cref="UInt64"/> from stream using little endian encoding</returns>
        public UInt64 ReadUInt64() {
            Byte[] Data = new Byte[sizeof(UInt64)];
            this._BaseStream.Read(Data, 0, Data.Length);
            return Binary.BitConverter.LittleEndian.ToUInt64(Data);
        }
    }
}
