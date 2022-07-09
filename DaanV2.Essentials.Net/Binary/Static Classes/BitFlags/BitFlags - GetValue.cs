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
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static UInt32 GetFlagValue(Byte carrier, Int32 Bit) {
            return ((UInt32)carrier >> Bit) & 1u;
        }

        /// <summary>
        /// 
        ///</summary>
        /// <param name="carrier"></param>
        /// <param name="Bit"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static UInt32 GetFlagValue(UInt16 carrier, Int32 Bit) {
            return ((UInt32)carrier >> Bit) & 1u;
        }

        /// <summary>
        /// 
        ///</summary>
        /// <param name="carrier"></param>
        /// <param name="Bit"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static UInt32 GetFlagValue(UInt32 carrier, Int32 Bit) {
            return ((UInt32)carrier >> Bit) & 1u;
        }

        /// <summary>
        /// 
        ///</summary>
        /// <param name="carrier"></param>
        /// <param name="Bit"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static UInt64 GetFlagValue(UInt64 carrier, Int32 Bit) {
            return ((UInt64)carrier >> Bit) & 1ul;
        }
    }
}