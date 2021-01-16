using System;
using System.Collections.Generic;

namespace DaanV2.Threading {
    public sealed partial class FileLockManager : IEquatable<FileLockManager> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object obj) {
            return this.Equals(obj as FileLockManager);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Boolean Equals(FileLockManager other) {
            return other != null &&
                   this._RootCount == other._RootCount &&
                   this._LockPerRootCount == other._LockPerRootCount &&
                   EqualityComparer<LockPool[]>.Default.Equals(this._DriveLocks, other._DriveLocks);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Int32 GetHashCode() {
            return HashCode.Combine(this._DriveLocks, this._RootCount, this._LockPerRootCount);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator ==(FileLockManager left, FileLockManager right) {
            return EqualityComparer<FileLockManager>.Default.Equals(left, right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Boolean operator !=(FileLockManager left, FileLockManager right) {
            return !(left == right);
        }
    }
}
