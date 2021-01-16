using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace DaanV2.Threading {
    ///DOLATER <summary>add description for class: LookPoolExtension</summary>
    public static partial class LookPoolExtension {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EventWaitHandle GetHandle<U>(this ILockPool<Int32> Pool, U value) {
            return Pool.GetHandle(value.GetHashCode());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EventWaitHandle GetHandle(this ILockPool<Int32> Pool, String value) {
            return GetHandle<String>(Pool, value);
        }
    }
}
