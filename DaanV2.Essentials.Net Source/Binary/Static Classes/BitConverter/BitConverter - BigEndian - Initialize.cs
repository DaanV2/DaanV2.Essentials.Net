using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Binary {
    ///DOLATER <summary>add description for class: BitConverter</summary>
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
