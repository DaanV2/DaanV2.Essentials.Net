using System;
using System.Runtime.CompilerServices;

namespace DaanV2.Threading {
    ///DOLATER <summary>add description for class: LookPoolExtension</summary>
    public static partial class LookPoolExtension {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LockInstance GetInstance<T>(this ILockPool<T> Pool, T Index) {
            return LockInstance.Create(Pool.GetHandle(Index));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LockInstance GetInstanceWait<T>(this ILockPool<T> Pool, T Index) {
            return LockInstance.CreateWait(Pool.GetHandle(Index));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LockInstance GetInstance(this ILockPool<Int32> Pool, String Index) {
            return LockInstance.Create(Pool.GetHandle(Index));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LockInstance GetInstanceWait<T>(this ILockPool<Int32> Pool, String Index) {
            return LockInstance.CreateWait(Pool.GetHandle(Index));
        }
    }
}
