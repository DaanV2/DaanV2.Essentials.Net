using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DaanV2.Threading {
    ///DOLATER <summary>add description for class: LookPoolExtension</summary>
    public static partial class LookPoolExtension {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EventWaitHandle GetHandle<T>(this ILockPool<Int32> Pool, T value) {
            return Pool.GetHandle(value.GetHashCode());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LockInstance GetInstance<T>(this ILockPool<Int32> Pool, T value) {
            return Pool.GetInstance(value.GetHashCode());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LockInstance GetInstanceWait<T>(this ILockPool<Int32> Pool, T value) {
            return Pool.GetInstanceWait(value.GetHashCode());
        }
    }
}
