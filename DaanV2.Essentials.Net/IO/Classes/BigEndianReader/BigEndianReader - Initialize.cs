using System.IO;

namespace DaanV2.IO {
    ///DOLATER <summary>add description for class: LittleEndianReader</summary>
    public partial class BigEndianReader {
        /// <summary>Creates a new instance of <see cref="BigEndianReader"/></summary>
        public BigEndianReader(Stream BaseStream) {
            this._BaseStream = BaseStream;
        }
    }
}
