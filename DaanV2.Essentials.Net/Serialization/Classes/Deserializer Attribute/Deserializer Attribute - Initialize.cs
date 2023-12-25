using System;
using System.Runtime.Serialization;

namespace DaanV2.Serialization {
    /// <summary>The attribute that marks a class that it is a deserializer and what factory it belongs to.</summary>
	[Serializable, DataContract, AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public partial class DeserializerAttribute : Attribute {

        /// <summary>Creates a new instance of <see cref="DeserializerAttribute"/>.</summary>
        public DeserializerAttribute() : this(String.Empty) { }

        /// <summary>Creates a new instance of <see cref="DeserializerAttribute"/>.</summary>
        /// <param name="Name">FILL_ME_IN.</param>
        public DeserializerAttribute(String Name) {
            this._FactoryName = Name;
        }
    }
}