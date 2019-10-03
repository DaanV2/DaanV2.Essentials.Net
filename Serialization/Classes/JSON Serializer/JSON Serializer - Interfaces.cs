using System;
using System.IO;

namespace DaanV2.Serialization {
    public partial class JSONSerializer<TypeSerialize> :
        ISerializer<TypeSerialize, Stream>,
        IDeserializer<TypeSerialize, Stream> {

        /// <summary>Deserialize the given stream into the specified <see cref="Type"/></summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public TypeSerialize Deserialize(Stream stream) {
            return (TypeSerialize)this.serializer.ReadObject(stream);
        }

        /// <summary>Serializes the given object into the given stream</summary>
        /// <param name="O"></param>
        /// <param name="stream"></param>
        public void Serialize(TypeSerialize O, Stream stream) {
            this.serializer.WriteObject(stream, O);
        }
    }
}
