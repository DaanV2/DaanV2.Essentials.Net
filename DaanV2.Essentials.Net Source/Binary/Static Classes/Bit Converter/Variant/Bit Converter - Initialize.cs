/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;

namespace DaanV2.Binary {
    
    public static partial class BitConverter {
#if UNSAFE
        /// <summary>Provides support to convert byte array to Varint, compiled with /unsafe</summary>
        public static partial class Varint { }
#else
        /// <summary>Provides support to convert byte array to Varint</summary>
        public static partial class Varint { }
#endif
    }
}
