/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Diagnostics.CodeAnalysis;

namespace DaanV2.Serialization {
    /// <summary>The interface responsible for form the contract on what a SerializerFactory should contain.</summary>
    /// <typeparam name="TypeStream">The type of stream used by the serializers.</typeparam>
    public interface ISerializerFactory<TypeStream> {
        /// <summary>Returns a serializer that is able to serialize the given type through the given stream.</summary>
        /// <typeparam name="TIn">The type to create a serializer for.</typeparam>
        /// <returns>Returns a serializer that is able to serialize the given type through the given stream.</returns>
        [return: NotNull]
        ISerializer<TIn, TypeStream> GetSerializer<TIn>();

        /// <summary>Returns a deserializer that is able to deserialize the given type through the given stream.</summary>
        /// <typeparam name="TOut">The type to create a deserializer for.</typeparam>
        /// <returns>Returns a deserializer that is able to deserialize the given type through the given stream.</returns>
        [return: NotNull]
        IDeserializer<TOut, TypeStream> GetDeserializer<TOut>();

        /// <summary>Sets the deserializer type.</summary>
        /// <param name="Deserializer">The type to set as the deserializer.</param>
        void SetDeserializeType([NotNull] Type Deserializer);

        /// <summary>Sets the serializer type.</summary>
        /// <param name="Serializer">The type to set as the serializer.</param>
        void SetSerializeType([NotNull] Type Serializer);

        /// <summary>Gets the deserializer.</summary>
        [return: NotNull]
        Type GetDeserializeType();

        /// <summary>Gets the serializer type.</summary>
        [return: NotNull]
        Type GetSerializeType();

        /// <summary>Gets the name of the serializer factory.</summary>        
        String Name { [return: NotNull] get; }
    }
}
