/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Diagnostics.CodeAnalysis;

namespace DaanV2.Serialization {
    /// <summary>The basic serialization factory that allows for creation of (de)serializer of a generic type.</summary>
    public partial class SerializationFactory {
        /// <summary>Creates a new instance of <see cref="SerializationFactory"/>.</summary>
        /// <param name="Name">The name of this factory.</param>
        public SerializationFactory([NotNull] String Name) {
            this.Name = Name;
            this.Deserializer = null;
            this.Serializer = null;
        }

        /// <summary>Creates a new instance of <see cref="SerializationFactory"/>.</summary>
        public SerializationFactory() : this(String.Empty) { }
    }
}