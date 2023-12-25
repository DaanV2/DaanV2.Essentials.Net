using System.IO;

namespace DaanV2.IO {
    ///DOLATER <summary>add description for class: BigEndianWriter</summary>
    public partial class BigEndianWriter : WrapperStream {
        /// <summary>Creates a new instance of <see cref="BigEndianWriter"/></summary>
        public BigEndianWriter(Stream BaseStream) : base(BaseStream) {

        }
    }
}