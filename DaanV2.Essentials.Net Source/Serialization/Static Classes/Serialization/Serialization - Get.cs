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
using System.IO;

namespace DaanV2.Serialization {
    public static partial class Serialization {

        /// <summary>Returns the factory with the specified name
        /// <para>If no factory is found, then one is made.</para>.</summary>
        /// <param name="Name">The name of the specified name.</param>
        /// <returns>Returns the factory with the specified name.</returns>
        private static ISerializerFactory<Stream> GetFactory(String Name) {
            if (!Serialization._Factories.ContainsKey(Name)) {
                Serialization._Factories[Name] = new SerializationFactory();
            }

            return Serialization._Factories[Name];
        }

        /// <summary>Returns a deserializer from the specified factory.</summary>
        /// <typeparam name="TypeOut">The type to deserializer.</typeparam>
        /// <param name="FactoryName">The name of the factory to usee.</param>
        /// <returns>A deserializer of type <see cref="IDeserializer{TypeOut, Stream}"/>.</returns>
        public static IDeserializer<TypeOut, Stream> GetDeserializer<TypeOut>(String FactoryName) {
            if (!Serialization._Factories.ContainsKey(FactoryName)) {
                throw new Exception("No factory has been found with the name " + FactoryName);
            }

            return Serialization._Factories[FactoryName].GetDeserializer<TypeOut>();
        }

        /// <summary>Returns a serializer from the specified factory.</summary>
        /// <typeparam name="TypeIn">The type to serializer.</typeparam>
        /// <param name="FactoryName">The name of the factory to usee.</param>
        /// <returns>A serializer of type <see cref="ISerializer{TypeIn, Stream}"/>.</returns>
        public static ISerializer<TypeIn, Stream> GetSerializer<TypeIn>(String FactoryName) {
            if (!Serialization._Factories.ContainsKey(FactoryName)) {
                throw new Exception("No factory has been found with the name " + FactoryName);
            }

            return Serialization._Factories[FactoryName].GetSerializer<TypeIn>();
        }
    }
}
