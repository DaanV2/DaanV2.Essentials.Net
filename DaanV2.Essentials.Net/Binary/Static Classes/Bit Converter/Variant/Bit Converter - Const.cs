using System;

namespace DaanV2.Binary {

    public static partial class BitConverter {
        public static partial class VarInt {
            /// <summary>The byte mask that is used to remove the signal bit</summary>
            private const Byte NonSignalMask = 0b0111_1111;

            /// <summary>The byte mask that holds</summary>
            private const Byte SignalMask = 0b1000_0000;
        }
    }
}