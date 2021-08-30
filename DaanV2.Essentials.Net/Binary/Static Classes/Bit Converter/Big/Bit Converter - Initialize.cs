/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

namespace DaanV2.Binary {
    
    public static partial class BitConverter {
#if UNSAFE
        /// <summary>Provides support to convert byte array to integer types, using big endian formats, compiled with /unsafe</summary>
        public static partial class BigEndian { }
#else
        /// <summary>Provides support to convert byte array to integer types, using big endian formats</summary>
        public static partial class BigEndian { }
#endif
    }
}
