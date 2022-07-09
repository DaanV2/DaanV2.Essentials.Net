using System;
using System.Buffers;
using System.IO;

namespace DaanV2.IO {
    ///DOLATER <summary>add description for class: LittleEndianReader</summary>
    public partial class LittleEndianReader : BufferedStream {
        /// <summary>Creates a new instance of <see cref="LittleEndianReader"/></summary>
        public LittleEndianReader(Stream BaseStream) {
            this._BaseStream = BaseStream;
            this._Buffer = ArrayPool<Byte>.Shared.Rent(8);
        }

        /// <summary>
        /// 
        /// </summary>
        ~LittleEndianReader() {
            ArrayPool<Byte>.Shared.Return(this._Buffer, false);
        }
    }
}