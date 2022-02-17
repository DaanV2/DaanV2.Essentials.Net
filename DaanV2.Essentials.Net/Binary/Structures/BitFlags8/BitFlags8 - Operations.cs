using System;

namespace DaanV2.Binary {
    public partial struct BitFlags8 {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static explicit operator Byte(BitFlags8 value) {
            return value._Flags;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static explicit operator BitFlags8(Byte value) {
            return new BitFlags8(value);
        }
    }
}
