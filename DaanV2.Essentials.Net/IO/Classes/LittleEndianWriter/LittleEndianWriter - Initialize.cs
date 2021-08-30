using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.IO {
    ///DOLATER <summary>add description for class: LittleEndianWriter</summary>
    public partial class LittleEndianWriter {
        /// <summary>Creates a new instance of <see cref="LittleEndianWriter"/></summary>
        public LittleEndianWriter(Stream BaseStream) {
            this._BaseStream = BaseStream;
        }
    }
}
