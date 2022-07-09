/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;

namespace DaanV2.Binary {

    public static partial class BitConverter {
        public static partial class Varint {
            /// <summary>The byte mask that is used to remove the signal bit</summary>
            private const Byte _NonSignalMask = 0b0111_1111;

            /// <summary>The byte mask that holds</summary>
            private const Byte _SignalMask = 0b1000_0000;
        }
    }
}