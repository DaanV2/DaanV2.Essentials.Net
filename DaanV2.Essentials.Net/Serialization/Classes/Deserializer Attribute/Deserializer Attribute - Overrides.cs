using System;

namespace DaanV2.Serialization {
    public partial class DeserializerAttribute : IEquatable<DeserializerAttribute> {
        /// <summary>When implemented in a derived class, gets a unique identifier for this attribute.</summary>
        public override Object TypeId => base.TypeId;

        /// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
        /// <param name="obj">The object to check against.</param>
        /// <returns>Returns a value that indicates whether this instance is equal to a specified object.</returns>
        public override Boolean Equals(Object obj) {
            return obj is DeserializerAttribute DA ? DA._FactoryName == this._FactoryName : base.Equals(obj);
        }

        /// <summary>Check if this attribute matches the specified <see cref="Object"/>.</summary>
        /// <param name="obj">The object to compare to.</param>
        /// <returns>Check if this attribute matches the specified <see cref="Object"/>.</returns>
        public override Boolean Match(Object obj) {
            return obj is DeserializerAttribute DA ? DA._FactoryName == this._FactoryName : base.Match(obj);
        }

        /// <summary>Returns a string that represents this object.</summary>
        /// <returns>Returns a string that represents this object.</returns>
        public override String ToString() {
            return $"Deserializer: {this._FactoryName}";
        }

        /// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
        /// <param name="other">The object to check against.</param>
        /// <returns>Returns a value that indicates whether this instance is equal to a specified object.</returns>
        public Boolean Equals(DeserializerAttribute other) {
            return other is not null && this._FactoryName == other._FactoryName;
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>Returns the hash code for this instance.</returns>
        public override Int32 GetHashCode() {
            return HashCode.Combine(base.GetHashCode(), this.FactoryName);
        }

        /// <summary>Compare two <see cref="DeserializerAttribute"/> if they are equal to each other.</summary>
        /// <param name="left">The first <see cref="DeserializerAttribute"/> to check.</param>
        /// <param name="right">The second <see cref="DeserializerAttribute"/> to check.</param>
        /// <returns>Compare two <see cref="DeserializerAttribute"/> if they are equal to each other.</returns>
        public static Boolean operator ==(DeserializerAttribute left, DeserializerAttribute right) {
            if (Object.ReferenceEquals(left, right)) {
                return true;
            }

            Boolean L = left is not null;
            Boolean R = right is not null;

            if (L == R) {
                if (L) {
                    return left.FactoryName == right.FactoryName;
                }

                return true;
            }

            return false;
        }

        /// <summary>Compare two <see cref="DeserializerAttribute"/> if they are not equal to each other.</summary>
        /// <param name="left">The first <see cref="DeserializerAttribute"/> to check.</param>
        /// <param name="right">The second <see cref="DeserializerAttribute"/> to check.</param>
        /// <returns>Compare two <see cref="DeserializerAttribute"/> if they are not equal to each other.</returns>
        public static Boolean operator !=(DeserializerAttribute left, DeserializerAttribute right) {
            if (Object.ReferenceEquals(left, right)) {
                return false;
            }

            Boolean L = left is not null;
            Boolean R = right is not null;

            if (L == R) {
                if (L) {
                    return left.FactoryName != right.FactoryName;
                }

                return false;
            }

            return true;
        }
    }
}