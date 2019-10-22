/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.


THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS.IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;
using System.IO;

namespace DaanV2.Serialization {
    public partial class SerializationFactory : ISerializerFactory<Stream> {

        /// <summary>Returns a deserializer that is able to deserializer the given object</summary>
        /// <typeparam name="TOut">The type that needs to be returned after deserializing</typeparam>
        /// <returns><see cref="IDeserializer{TOut, Stream}"/></returns>
        public IDeserializer<TOut, Stream> GetDeserializer<TOut>() {
            if (this.Deserializer == null) {
                throw new Exception($"Deserializer type for '{this.Name}' not filled in");
            }

            return this.Deserializer.IsGenericType
                ? (IDeserializer<TOut, Stream>)Activator.CreateInstance(this.Deserializer.MakeGenericType(typeof(TOut)))
                : (IDeserializer<TOut, Stream>)Activator.CreateInstance(this.Deserializer);
        }

        /// <summary>Returns a serializer that is able to serializer the given object</summary>
        /// <typeparam name="TIn">The type that is being inputted for serialization</typeparam>
        /// <returns><see cref="ISerializer{TypeIn, Stream}"/></returns>
        public ISerializer<TIn, Stream> GetSerializer<TIn>() {
            if (this.Serializer == null) {
                throw new Exception($"Serializer type for '{this.Name}' not filled in");
            }

            return this.Serializer.IsGenericType
                ? (ISerializer<TIn, Stream>)Activator.CreateInstance(this.Serializer.MakeGenericType(typeof(TIn)))
                : (ISerializer<TIn, Stream>)Activator.CreateInstance(this.Serializer);
        }

        /// <summary>Returns a serializer that is able to serializer the given object</summary>
        /// <param name="ForType">The type that is being inputted for serialization</typeparam>
        /// <returns><see cref="ISerializer{Object, Stream}"/></returns>
        public ISerializer<Object, Stream> GetSerializer(Type ForType) {
            if (this.Serializer == null) {
                throw new Exception($"Serializer type for '{this.Name}' not filled in");
            }

            return this.Serializer.IsGenericType
                ? (ISerializer<Object, Stream>)Activator.CreateInstance(this.Serializer.MakeGenericType(ForType))
                : (ISerializer<Object, Stream>)Activator.CreateInstance(this.Serializer);
        }

        /// <summary>Gets the deserializing base type</summary>
        /// <returns><see cref="Type"/></returns>
        public Type GetDeserializeType() {
            return this.Deserializer;
        }

        /// <summary>Gets the serializing base type</summary>
        /// <returns><see cref="Type"/></returns>
        public Type GetSerializeType() {
            return this.Serializer;
        }

        /// <summary>Sets the deserializing base type</summary>
        /// <param name="Deserialize">The type to set as the base for deserializers</param>
        public void SetDeserializeType(Type Deserialize) {
            this.Deserializer = Deserialize;
        }

        /// <summary>Sets the serializing base type</summary>
        /// <param name="Serialize">The type to set as the base for serializers</param>
        public void SetSerializeType(Type Serialize) {
            this.Serializer = Serialize;
        }
    }
}
