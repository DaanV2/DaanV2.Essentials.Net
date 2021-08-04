using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.IO {
    public partial class LittleEndianReader : Stream {
        public override Boolean CanRead => this._BaseStream.CanRead;
        public override Boolean CanSeek => this._BaseStream.CanSeek;
        public override Boolean CanWrite => this._BaseStream.CanWrite;
        public override Int64 Length => this._BaseStream.Length;
        public override Int64 Position { get => this._BaseStream.Position; set => this._BaseStream.Position = value; }
        public override void Flush() {
            this._BaseStream.Flush();
        }

        public override Int32 Read(Byte[] buffer, Int32 offset, Int32 count) {
            return this._BaseStream.Read(buffer, offset, count);
        }

        public override Int64 Seek(Int64 offset, SeekOrigin origin) {
            return this._BaseStream.Seek(offset, origin);
        }

        public override void SetLength(Int64 value) {
            this._BaseStream.SetLength(value);
        }

        public override void Write(Byte[] buffer, Int32 offset, Int32 count) {
            this._BaseStream.Write(buffer, offset, count);
        }
    }
}
