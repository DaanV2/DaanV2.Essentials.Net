/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System.Runtime.Serialization.Formatters.Binary;

namespace DaanV2.Serialization {
#if !NET5
    /// <summary>The serializer class that is responsible for serializing to a binary format</summary>
    [Serializer("binary"), Deserializer("binary")]
    public partial class BinarySerializer<TypeSerialize> {
        /// <summary>Creates a new instance of <see cref="BinarySerializer{TypeSerialize}"/>.</summary>
        public BinarySerializer() {
            this._Serializer = new BinaryFormatter();
        }
    }

#endif
}
