/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.


THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;

namespace DaanV2.Serialization {
    /// <summary>The interface responsible for form the contract on what a SerializerFactory should contain</summary>
    /// <typeparam name="TypeStream">The type of stream used by the serializers</typeparam>
    public interface ISerializerFactory<TypeStream> {

        /// <summary>Returns a serializer that is able to serialize the given type through the given stream</summary>
        /// <typeparam name="TIn">The type to create a serializer for</typeparam>
        /// <returns>Returns a serializer that is able to serialize the given type through the given stream</returns>
        ISerializer<TIn, TypeStream> GetSerializer<TIn>();

        /// <summary>Returns a deserializer that is able to deserialize the given type through the given stream</summary>
        /// <typeparam name="TOut">The type to create a deserializer for</typeparam>
        /// <returns>Returns a deserializer that is able to deserialize the given type through the given stream</returns>
        IDeserializer<TOut, TypeStream> GetDeserializer<TOut>();

        /// <summary>Sets the deserializer type</summary>
        /// <param name="Deserialize">The type to set as the deserializer</param>
        void SetDeserializeType(Type Deserializer);

        /// <summary>Sets the serializer type</summary>
        /// <param name="Serialize">The type to set as the serializer</param>
        void SetSerializeType(Type Serializer);

        /// <summary>Gets the deserializer</summary>
        Type GetDeserializeType();

        /// <summary>Gets the serializer type</summary>
        Type GetSerializeType();

        /// <summary>Gets the name of the serializer factory</summary>
        String Name {
            get;
        }
    }
}
