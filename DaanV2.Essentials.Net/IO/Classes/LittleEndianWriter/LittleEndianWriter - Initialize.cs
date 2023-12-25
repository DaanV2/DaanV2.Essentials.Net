using System.IO;

namespace DaanV2.IO {
    ///DOLATER <summary>add description for class: LittleEndianWriter</summary>
    public partial class LittleEndianWriter : WrapperStream {
        /// <summary>Creates a new instance of <see cref="LittleEndianWriter"/></summary>
        public LittleEndianWriter(Stream BaseStream) : base(BaseStream) {
        }
    }
}