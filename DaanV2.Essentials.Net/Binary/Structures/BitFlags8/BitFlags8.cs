using System;

namespace DaanV2.Binary {
    /// <summary>add description for struct: BitFlags</summary>
    public partial struct BitFlags8 {
        private Byte _Flags;

        /// <summary>Creates a new instance of <see cref="BitFlags"/></summary>
        private BitFlags8(Byte Data) {
            this._Flags = Data;
        }
    }
}