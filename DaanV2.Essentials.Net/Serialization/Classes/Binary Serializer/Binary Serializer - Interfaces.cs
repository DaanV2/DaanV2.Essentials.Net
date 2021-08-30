/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System.IO;

namespace DaanV2.Serialization {
#if !NET5
    public partial class BinarySerializer<TypeSerialize> :
        ISerializer<TypeSerialize, Stream>,
        IDeserializer<TypeSerialize, Stream> {

        /// <summary>Deserialize the given stream into the specified type.</summary>
        /// <param name="stream">The stream to read from.</param>
        /// <returns>Deserialize the given stream into the specified type.</returns>
        public TypeSerialize Deserialize(Stream stream) {
            return (TypeSerialize)this._Serializer.Deserialize(stream);
        }

        /// <summary>Serializes the given object into the given stream.</summary>
        /// <param name="O">The object to serialize.</param>
        /// <param name="stream">The stream to write to.</param>
        public void Serialize(TypeSerialize O, Stream stream) {
            this._Serializer.Serialize(stream, O);
        }
    }
#endif
}
