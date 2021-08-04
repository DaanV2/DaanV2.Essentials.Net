using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.IO {
    public partial class BigEndianReader : Stream {
        /// <summary>Writes an <see cref="Int16"/> to stream using big endian encoding</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Value">The value to write to stream</param>
        public void Write(Int16 Value) {
            Byte[] Data = Binary.BitConverter.BigEndian.ToBytes(Value);
            this.Write(Data, 0, Data.Length);
        }

        /// <summary>Writes an <see cref="Int32"/> to stream using big endian encoding</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Value">The value to write to stream</param>
        public void Write(Int32 Value) {
            Byte[] Data = Binary.BitConverter.BigEndian.ToBytes(Value);
            this.Write(Data, 0, Data.Length);
        }

        /// <summary>Writes an <see cref="Int64"/> to stream using big endian encoding</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Value">The value to write to stream</param>
        public void Write(Int64 Value) {
            Byte[] Data = Binary.BitConverter.BigEndian.ToBytes(Value);
            this.Write(Data, 0, Data.Length);
        }

        /// <summary>Writes an <see cref="UInt16"/> to stream using big endian encoding</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Value">The value to write to stream</param>
        public void Write(UInt16 Value) {
            Byte[] Data = Binary.BitConverter.BigEndian.ToBytes(Value);
            this.Write(Data, 0, Data.Length);
        }

        /// <summary>Writes an <see cref="UInt32"/> to stream using big endian encoding</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Value">The value to write to stream</param>
        public void Write(UInt32 Value) {
            Byte[] Data = Binary.BitConverter.BigEndian.ToBytes(Value);
            this.Write(Data, 0, Data.Length);
        }

        /// <summary>Writes an <see cref="UInt64"/> to stream using big endian encoding</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Value">The value to write to stream</param>
        public void Write(UInt64 Value) {
            Byte[] Data = Binary.BitConverter.BigEndian.ToBytes(Value);
            this.Write(Data, 0, Data.Length);
        }
    }
}
