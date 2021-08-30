/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System.IO;

namespace DaanV2.Serialization {
    public partial class XmlSerializer<TypeSerialize> : ISerializer<TypeSerialize, Stream>, IDeserializer<TypeSerialize, Stream> {

        /// <summary>Deserialize the given stream into the specified object.</summary>
        /// <param name="stream">The strean to read the object from.</param>
        /// <returns>Deserialize the given stream into the specified object.</returns>
        public TypeSerialize Deserialize(Stream stream) {
            return (TypeSerialize)this._Serializer.Deserialize(stream);
        }

        /// <summary>Serialize the given object in the given stream.</summary>
        /// <param name="O">The object to serialize.</param>
        /// <param name="stream">The stream to write the object to.</param>
        public void Serialize(TypeSerialize O, Stream stream) {
            this._Serializer.Serialize(stream, O);
        }
    }
}
