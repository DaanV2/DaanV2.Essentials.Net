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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Serialization {
    public partial class SerializationFactory : ISerializerFactory<Stream> {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TOut"></typeparam>
        /// <returns></returns>
        public IDeserializer<TOut, Stream> GetDeserializer<TOut>() {
            if (this.Deserializer == null)
                throw new Exception($"Deserializer type for '{this.Name}' not filled in");

            return (IDeserializer<TOut, Stream>)Activator.CreateInstance(this.Deserializer.MakeGenericType(typeof(TOut)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ForType"></param>
        /// <returns></returns>
        public IDeserializer<Object, Stream> GetDeserializer(Type ForType) {
            if (this.Deserializer == null)
                throw new Exception($"Deserializer type for '{this.Name}' not filled in");

            return (IDeserializer<Object, Stream>)Activator.CreateInstance(this.Deserializer.MakeGenericType(ForType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TIn"></typeparam>
        /// <returns></returns>
        public ISerializer<TIn, Stream> GetSerializer<TIn>() {
            if (this.Serializer == null)
                throw new Exception($"Serializer type for '{this.Name}' not filled in");

            return (ISerializer<TIn, Stream>)Activator.CreateInstance(this.Serializer.MakeGenericType(typeof(TIn)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ForType"></param>
        /// <returns></returns>
        public ISerializer<Object, Stream> GetSerializer(Type ForType) {
            if (this.Serializer == null)
                throw new Exception($"Serializer type for '{this.Name}' not filled in");

            return (ISerializer<Object, Stream>)Activator.CreateInstance(this.Serializer.MakeGenericType(ForType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Deserialize"></param>
        public void SetDeserializeType(Type Deserialize) {
            this.Deserializer = Deserialize;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Deserialize"></param>
        public void SetSerializeType(Type Serialize) {
            this.Serializer = Serialize;
        }
    }
}
