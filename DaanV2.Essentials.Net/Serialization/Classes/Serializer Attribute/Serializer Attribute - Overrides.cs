/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;

namespace DaanV2.Serialization {
    public partial class SerializerAttribute : IEquatable<SerializerAttribute> {

        /// <summary>When implemented in a derived class, gets a unique identifier for this attribute.</summary>
        public override Object TypeId => base.TypeId;

        /// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
        /// <param name="obj">The object to check against.</param>
        /// <returns>Returns a value that indicates whether this instance is equal to a specified object.</returns>
        public override Boolean Equals(Object obj) {
            return obj is SerializerAttribute SA ? this.Equals(SA) : base.Match(obj);
        }

        /// <summary>Check if this attribute matches the specified <see cref="Object"/>.</summary>
        /// <param name="obj">The object to compare to.</param>
        /// <returns>Check if this attribute matches the specified <see cref="Object"/>.</returns>
        public override Boolean Match(Object obj) {
            return obj is SerializerAttribute SA ? this.Equals(SA) : base.Match(obj);
        }

        /// <summary>Returns a string that represents this object.</summary>
        /// <returns>Returns a string that represents this object.</returns>
        public override String ToString() {
            return $"Deserializer: {this._FactoryName}";
        }

        /// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
        /// <param name="other">The object to check against.</param>
        /// <returns>Returns a value that indicates whether this instance is equal to a specified object.</returns>
        public Boolean Equals(SerializerAttribute other) {
            if (other != null && this._FactoryName == other._FactoryName) return true;

            return false;
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>Returns the hash code for this instance.</returns>
        public override Int32 GetHashCode() {
            return HashCode.Combine(base.GetHashCode(), this.FactoryName);
        }

        /// <summary>Compare two <see cref="SerializableAttribute"/> if they are equal to each other.</summary>
        /// <param name="left">The first <see cref="SerializableAttribute"/> to check.</param>
        /// <param name="right">The second <see cref="SerializableAttribute"/> to check.</param>
        /// <returns>Compare two <see cref="SerializableAttribute"/> if they are equal to each other.</returns>
        public static Boolean operator ==(SerializerAttribute left, SerializerAttribute right) {
            if (Object.ReferenceEquals(left, right)) {
                return true;
            }

            Boolean L = left is Object;
            Boolean R = right is Object;

            if (L == R) {
                return L ? left.FactoryName == right.FactoryName : true;
            }

            return false;
        }

        /// <summary>Compare two <see cref="SerializableAttribute"/> if they are not equal to each other.</summary>
        /// <param name="left">The first <see cref="SerializableAttribute"/> to check.</param>
        /// <param name="right">The second <see cref="SerializableAttribute"/> to check.</param>
        /// <returns>Compare two <see cref="SerializableAttribute"/> if they are not equal to each other.</returns>
        public static Boolean operator !=(SerializerAttribute left, SerializerAttribute right) {
            if (Object.ReferenceEquals(left, right)) {
                return false;
            }

            Boolean L = left is Object;
            Boolean R = right is Object;

            if (L == R) {
                return L ? left.FactoryName != right.FactoryName : false;
            }

            return true;
        }
    }
}
