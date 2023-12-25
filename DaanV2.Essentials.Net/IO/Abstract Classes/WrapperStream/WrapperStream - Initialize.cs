using System.IO;

namespace DaanV2.IO {
    /// <summary>An class that wraps around a base stream as a field</summary>
    public abstract partial class WrapperStream : Stream {
        /// <summary>Creates a new instance of <see cref="WrapperStream"/></summary>
        /// <param name="BaseStream"></param>
        protected WrapperStream(Stream BaseStream) {
            this._BaseStream = BaseStream;
        }

        ~WrapperStream() {
            this.Dispose(false);
        }
    }
}
