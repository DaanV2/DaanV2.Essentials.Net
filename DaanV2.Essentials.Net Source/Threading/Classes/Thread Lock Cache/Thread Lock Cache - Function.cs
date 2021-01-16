namespace DaanV2.Threading {
    public sealed partial class ThreadLockCache<T, U>
        where T : ILockPool<U> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Filepath"></param>
        /// <returns></returns>
        public LockInstance GetInstance(T Index) {
            if (this._Locks.TryGetValue(Index, out LockInstance value)) {
                return value;
            }

            LockInstance Lock = this._Pool.GetInstance(Index);
            this._Locks[Index] = Lock;
            return Lock;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public LockInstance GetInstanceWait(T Index) {
            LockInstance Lock = this.GetInstance(Index);
            Lock.Lock();

            return Lock;
        }
    }
}
