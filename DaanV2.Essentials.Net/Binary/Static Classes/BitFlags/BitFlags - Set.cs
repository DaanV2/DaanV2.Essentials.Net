using System;
using System.Runtime.CompilerServices;

namespace DaanV2.Binary {
    ///DOLATER <summary>add description for class: BitFlags</summary>
    public static partial class BitFlags {
        /// <summary>
        /// 
        ///</summary>
        /// <param name="carrier"></param>
        /// <param name="Bit"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static void SetFlag(ref Byte carrier, Int32 Bit, Boolean Value) {
            UInt32 mask = 1u << Bit;

            if (Value)
                carrier = (Byte)(carrier | mask);
            else
                carrier = (Byte)(carrier & ~(mask));
        }

        /// <summary>
        /// 
        ///</summary>
        /// <param name="carrier"></param>
        /// <param name="Bit"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static void SetFlag(ref UInt16 carrier, Int32 Bit, Boolean Value) {
            UInt32 mask = 1u << Bit;

            if (Value)
                carrier = (UInt16)(carrier | mask);
            else
                carrier = (UInt16)(carrier & ~(mask));
        }

        /// <summary>
        /// 
        ///</summary>
        /// <param name="carrier"></param>
        /// <param name="Bit"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static void SetFlag(ref UInt32 carrier, Int32 Bit, Boolean Value) {
            UInt32 mask = 1u << Bit;

            if (Value)
                carrier = (UInt32)(carrier | mask);
            else
                carrier = (UInt32)(carrier & ~(mask));
        }


        /// <summary>
        /// 
        ///</summary>
        /// <param name="carrier"></param>
        /// <param name="Bit"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static void SetFlag(ref UInt64 carrier, Int32 Bit, Boolean Value) {
            UInt64 mask = 1uL << Bit;

            if (Value)
                carrier = (UInt64)(carrier | mask);
            else
                carrier = (UInt64)(carrier & ~(mask));
        }
    }
}
