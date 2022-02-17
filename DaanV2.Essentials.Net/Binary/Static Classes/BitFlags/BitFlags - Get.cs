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
        public static Boolean GetFlag(Byte carrier, Int32 Bit) {
            return (carrier & (1u << Bit)) != 0;
        }

        /// <summary>
        /// 
        ///</summary>
        /// <param name="carrier"></param>
        /// <param name="Bit"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Boolean GetFlag(UInt16 carrier, Int32 Bit) {
            return (carrier & (1u << Bit)) != 0;
        }

        /// <summary>
        /// 
        ///</summary>
        /// <param name="carrier"></param>
        /// <param name="Bit"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Boolean GetFlag(UInt32 carrier, Int32 Bit) {
            return (carrier & (1u << Bit)) != 0;
        }

        /// <summary>
        /// 
        ///</summary>
        /// <param name="carrier"></param>
        /// <param name="Bit"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Boolean GetFlag(UInt64 carrier, Int32 Bit) {
            return (carrier & (1ul << Bit)) != 0;
        }
    }
}
