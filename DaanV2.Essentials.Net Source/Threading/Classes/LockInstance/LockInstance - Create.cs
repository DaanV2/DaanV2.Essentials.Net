using System.Threading;

namespace DaanV2.Threading {
    public sealed partial class LockInstance {
        /// <summary>Creates a lock but does NOT lock it automaticly, only give this object to 1 thread</summary>
        /// <param name="Lock"></param>
        /// <returns>Creates a instance of the lock that can only be used by 1 thread</returns>
        public static LockInstance Create(EventWaitHandle Lock) {
            return new LockInstance(Lock);
        }

        /// <summary>Creates a lock but does lock it automaticly, only give this object to 1 thread</summary>
        /// <param name="Lock">The lock to wrap around</param>
        /// <returns>Creates a instance of the lock that can only be used by 1 thread</returns>
        public static LockInstance CreateWait(EventWaitHandle Lock) {
            var Out = new LockInstance(Lock);
            Out.Lock();

            return Out;
        }
    }
}
