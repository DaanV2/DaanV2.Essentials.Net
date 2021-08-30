/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Runtime.Serialization;

namespace DaanV2.Serialization {
    /// <summary>The attribute that marks a class that it is a serializer and what factory it belongs to.</summary>
	[Serializable, DataContract, AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public partial class SerializerAttribute : Attribute {

        /// <summary>Creates a new instance of <see cref="SerializerAttribute"/>.</summary>
        public SerializerAttribute() : this(String.Empty) { }

        /// <summary>Creates a new instance of <see cref="SerializerAttribute"/>.</summary>
        /// <param name="Name">The name of the factory.</param>
        public SerializerAttribute(String Name) {
            this.FactoryName = Name;
        }
    }
}
