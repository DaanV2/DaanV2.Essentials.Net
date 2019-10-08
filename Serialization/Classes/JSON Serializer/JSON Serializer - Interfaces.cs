using System;
using System.IO;

namespace DaanV2.Serialization {
    public partial class JSONSerializer<TypeSerialize> :
        ISerializer<TypeSerialize, Stream>,
        IDeserializer<TypeSerialize, Stream> {

        /// <summary>Deserialize the given stream into the specified <see cref="Type"/></summary>
        /// <param name="stream">FILL_ME_IN</param>
        /// <returns></returns>
        public TypeSerialize Deserialize(Stream stream) {
            return (TypeSerialize)this.serializer.ReadObject(stream);
        }

        /// <summary>Serializes the given object into the given stream</summary>
        /// <param name="O">FILL_ME_IN</param>
        /// <param name="stream">FILL_ME_IN</param>
        public void Serialize(TypeSerialize O, Stream stream) {
            this.serializer.WriteObject(stream, O);
        }
    }
}
