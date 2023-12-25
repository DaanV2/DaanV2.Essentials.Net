using System.IO;

namespace DaanV2.IO {
    public abstract partial class WrapperStream : Stream {
        /// <summary>The wrapper stream</summary>
        protected readonly Stream _BaseStream;
    }
}
