using System;
using System.Buffers;
using System.IO;

namespace DaanV2.IO {
    ///DOLATER <summary>add description for class: LittleEndianWriter</summary>
    public partial class LittleEndianWriter : BufferedStream {
        /// <summary>Creates a new instance of <see cref="LittleEndianWriter"/></summary>
        public LittleEndianWriter(Stream BaseStream) {
            this._BaseStream = BaseStream;
        }
    }
}
