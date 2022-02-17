using System;

namespace DaanV2.Binary {
    public partial struct BitFlags8 : IEquatable<BitFlags8> {
        /// <inheritdoc/>
        public override Boolean Equals(Object obj) {
            return obj is BitFlags8 flags && this.Equals(flags);
        }

        /// <inheritdoc/>
        public Boolean Equals(BitFlags8 other) {
            return this._Flags == other._Flags;
        }

        /// <inheritdoc/>
        public override Int32 GetHashCode() {
            return this._Flags;
        }

        /// <inheritdoc/>
        public static Boolean operator ==(BitFlags8 left, BitFlags8 right) {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static Boolean operator !=(BitFlags8 left, BitFlags8 right) {
            return !(left == right);
        }

        /// <summary></summary>
        /// <returns></returns>
        public override String ToString() {
            Byte B = this._Flags;
            Span<Char> chars = stackalloc Char[8] {
                (Char)(BitFlags.GetFlagValue(B, 0) + '0'),
                (Char)(BitFlags.GetFlagValue(B, 1) + '0'),
                (Char)(BitFlags.GetFlagValue(B, 2) + '0'),
                (Char)(BitFlags.GetFlagValue(B, 3) + '0'),
                (Char)(BitFlags.GetFlagValue(B, 4) + '0'),
                (Char)(BitFlags.GetFlagValue(B, 5) + '0'),
                (Char)(BitFlags.GetFlagValue(B, 6) + '0'),
                (Char)(BitFlags.GetFlagValue(B, 7) + '0'),
            };

            return new String(chars);
        }
    }
}
