using System.IO;

namespace DaanV2.IO {
    ///DOLATER <summary>add description for class: BigEndianReader</summary>
    public partial class BigEndianReader : WrapperStream {
        /// <summary>Creates a new instance of <see cref="BigEndianReader"/></summary>
        public BigEndianReader(Stream BaseStream) : base(BaseStream) {
        }
    }
}