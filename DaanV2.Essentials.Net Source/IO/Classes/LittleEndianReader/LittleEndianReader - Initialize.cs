using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.IO {
    ///DOLATER <summary>add description for class: LittleEndianReader</summary>
    public partial class LittleEndianReader {
        /// <summary>Creates a new instance of <see cref="LittleEndianReader"/></summary>
        public LittleEndianReader(Stream BaseStream) {
            this._BaseStream = BaseStream;
        }
    }
}
