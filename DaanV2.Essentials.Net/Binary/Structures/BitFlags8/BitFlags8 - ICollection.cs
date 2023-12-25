using System;
using System.Collections;
using System.Collections.Generic;

namespace DaanV2.Binary {
    public partial struct BitFlags8 : IReadOnlyList<Boolean> {
        /// <inheritdoc/>
        public Boolean this[Int32 index] {
            get {
                if (index >= 8) throw new ArgumentOutOfRangeException(nameof(index));

                return BitFlags.GetFlag(this._Flags, index);
            }
            set {
                if (index >= 8) throw new ArgumentOutOfRangeException(nameof(index));

                BitFlags.SetFlag(ref this._Flags, index, value);
            }
        }

        /// <inheritdoc/>
        public readonly Int32 Count => 8;

        /// <inheritdoc/>
        public IEnumerator<Boolean> GetEnumerator() {
            return (IEnumerator<Boolean>)this.ToArray().GetEnumerator();
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() {
            return (IEnumerator<Boolean>)this.ToArray().GetEnumerator();
        }
    }
}