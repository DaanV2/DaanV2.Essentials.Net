using System;

namespace DaanV2.IO {
    public abstract partial class WrapperStream {
        /// <inheritdoc/>
        public new void Dispose(Boolean disposing) {
            this._BaseStream.Dispose();
            base.Dispose(disposing);
        }
    }
}