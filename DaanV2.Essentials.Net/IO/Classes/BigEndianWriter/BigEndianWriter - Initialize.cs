using System;
using System.Buffers;
using System.IO;

namespace DaanV2.IO {
    ///DOLATER <summary>add description for class: BigEndianWriter</summary>
    public partial class BigEndianWriter : BufferedStream {
        /// <summary>Creates a new instance of <see cref="BigEndianWriter"/></summary>
        public BigEndianWriter(Stream BaseStream) {
            this._BaseStream = BaseStream;
        }
    }
}