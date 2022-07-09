using System;
using System.Buffers;
using System.IO;

namespace DaanV2.IO {
    ///DOLATER <summary>add description for class: LittleEndianReader</summary>
    public partial class BigEndianReader : BufferedStream {
        /// <summary>Creates a new instance of <see cref="BigEndianReader"/></summary>
        public BigEndianReader(Stream BaseStream) : base() {
            this._BaseStream = BaseStream;
        }
    }
}