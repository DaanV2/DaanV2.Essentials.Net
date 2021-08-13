/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.IO;

namespace DaanV2.Serialization {
    public partial class SerializationFactory : ISerializerFactory<Stream> {

        /// <summary>Returns a deserializer that is able to deserializer the given object.</summary>
        /// <typeparam name="TOut">The type that needs to be returned after deserializing.</typeparam>
        /// <returns>Returns a deserializer that is able to deserializer the given object.</returns>
        public IDeserializer<TOut, Stream> GetDeserializer<TOut>() {
            if (this.Deserializer == null) {
                throw new Exception($"Deserializer type for '{this.Name}' not filled in");
            }

            return this.Deserializer.IsGenericType
                ? (IDeserializer<TOut, Stream>)Activator.CreateInstance(this.Deserializer.MakeGenericType(typeof(TOut)))
                : (IDeserializer<TOut, Stream>)Activator.CreateInstance(this.Deserializer);
        }

        /// <summary>Returns a serializer that is able to serializer the given object.</summary>
        /// <typeparam name="TIn">The type that is being inputted for serialization.</typeparam>
        /// <returns>Returns a serializer that is able to serializer the given object.</returns>
        public ISerializer<TIn, Stream> GetSerializer<TIn>() {
            if (this.Serializer == null) {
                throw new Exception($"Serializer type for '{this.Name}' not filled in");
            }

            return this.Serializer.IsGenericType
                ? (ISerializer<TIn, Stream>)Activator.CreateInstance(this.Serializer.MakeGenericType(typeof(TIn)))
                : (ISerializer<TIn, Stream>)Activator.CreateInstance(this.Serializer);
        }

        /// <summary>Returns a serializer that is able to serializer the given object.</summary>
        /// <param name="ForType">The type that is being inputted for serialization.</param>
        /// <returns>Returns a serializer that is able to serializer the given object.</returns>
        public ISerializer<Object, Stream> GetSerializer(Type ForType) {
            if (this.Serializer == null) {
                throw new Exception($"Serializer type for '{this.Name}' not filled in");
            }

            return this.Serializer.IsGenericType
                ? (ISerializer<Object, Stream>)Activator.CreateInstance(this.Serializer.MakeGenericType(ForType))
                : (ISerializer<Object, Stream>)Activator.CreateInstance(this.Serializer);
        }

        /// <summary>Gets the deserializing base type.</summary>
        /// <returns>Gets the deserializing base type.</returns>
        public Type GetDeserializeType() {
            return this.Deserializer;
        }

        /// <summary>Gets the serializing base type.</summary>
        /// <returns>Gets the serializing base type.</returns>
        public Type GetSerializeType() {
            return this.Serializer;
        }

        /// <summary>Sets the deserializing base type.</summary>
        /// <param name="Deserialize">The type to set as the base for deserializers.</param>
        public void SetDeserializeType(Type Deserialize) {
            this.Deserializer = Deserialize;
        }

        /// <summary>Sets the serializing base type.</summary>
        /// <param name="Serialize">The type to set as the base for serializers.</param>
        public void SetSerializeType(Type Serialize) {
            this.Serializer = Serialize;
        }
    }
}
