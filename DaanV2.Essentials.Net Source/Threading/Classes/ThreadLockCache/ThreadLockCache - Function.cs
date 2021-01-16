namespace DaanV2.Threading {
    public sealed partial class ThreadLockCache<T> {
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

        public LockInstance GetInstanceWait(T Index) {
            LockInstance Lock = this.GetInstance(Index);
            Lock.Lock();

            return Lock;
        }
    }
}
