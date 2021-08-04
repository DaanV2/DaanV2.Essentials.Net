using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.IO {
    ///DOLATER <summary>add description for class: BigEndianWriter</summary>
    public partial class BigEndianWriter {
        /// <summary>Creates a new instance of <see cref="BigEndianWriter"/></summary>
        public BigEndianWriter(Stream BaseStream) {
            this._BaseStream = BaseStream;
        }
    }
}
