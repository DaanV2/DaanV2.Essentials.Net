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
    public static partial class Serialization {
        /// <summary>Returns a deserializer from the specified factory</summary>
        /// <typeparam name="TypeOut">The type to deserializer</typeparam>
        /// <param name="FactoryName">The name of the factory to usee</param>
        /// <returns><see cref="IDeserializer{TypeOut, Stream}"/></returns>
        public static IDeserializer<TypeOut, Stream> GetDeserializer<TypeOut>(String FactoryName) {
            if (!Serialization.Factories.ContainsKey(FactoryName))
                throw new Exception("No factory has been found with the name " + FactoryName);

            return Serialization.Factories[FactoryName].GetDeserializer<TypeOut>();
        }

        /// <summary>Returns a deserializer from the specified factory</summary>
        /// <typeparam name="TypeOut">
        /// <param name="FactoryName">The name of the factory to usee</param>
        /// <param name="ForType">The type to deserializer</param>
        /// <returns><see cref="IDeserializer{Object, Stream}"/></returns>
        public static IDeserializer<Object, Stream> GetDeserializer(String FactoryName, Type ForType) {
            if (!Serialization.Factories.ContainsKey(FactoryName))
                throw new Exception("No factory has been found with the name " + FactoryName);

            return Serialization.Factories[FactoryName].GetDeserializer(ForType);
        }

        /// <summary>Returns a serializer from the specified factory</summary>
        /// <typeparam name="TypeIn">The type to serializer</typeparam>
        /// <param name="FactoryName">The name of the factory to usee</param>
        /// <returns><see cref="ISerializer{TypeIn, Stream}"/></returns>
        public static ISerializer<TypeIn, Stream> GetSerializer<TypeIn>(String FactoryName) {
            if (!Serialization.Factories.ContainsKey(FactoryName))
                throw new Exception("No factory has been found with the name " + FactoryName);

            return Serialization.Factories[FactoryName].GetSerializer<TypeIn>();
        }

        /// <summary>Returns a serializer from the specified factory</summary>
        /// <param name="FactoryName">The name of the factory to usee</param>
        /// <param name="ForType">The type to serialize</param>
        /// <returns><see cref="ISerializer{Object, Stream}"/></returns>
        public static ISerializer<Object, Stream> GetSerializer(String FactoryName, Type ForType) {
            if (!Serialization.Factories.ContainsKey(FactoryName))
                throw new Exception("No factory has been found with the name " + FactoryName);

            return Serialization.Factories[FactoryName].GetSerializer(ForType);
        }
    }
}
