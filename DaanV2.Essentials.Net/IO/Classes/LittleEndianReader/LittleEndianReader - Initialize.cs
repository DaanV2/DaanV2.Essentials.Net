using System.IO;

namespace DaanV2.IO {
    ///DOLATER <summary>add description for class: LittleEndianReader</summary>
    public partial class LittleEndianReader : WrapperStream {
        /// <summary>Creates a new instance of <see cref="LittleEndianReader"/></summary>
        public LittleEndianReader(Stream BaseStream) : base(BaseStream) { }
    }
}