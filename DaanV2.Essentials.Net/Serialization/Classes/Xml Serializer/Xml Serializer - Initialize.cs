/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

using System.Xml.Serialization;

namespace DaanV2.Serialization {
    /// <summary>A class that contects the build in JSON serializer from .Net into the <see cref="Serialization"/>.</summary>
    /// <typeparam name="TypeSerialize">The type to serializer/deserialize.</typeparam>
    [Serializer("xml"), Deserializer("xml")]
    public partial class XmlSerializer<TypeSerialize> {

        /// <summary>Creates a new instance of <see cref="XmlSerializer{TypeSerialize}"/>.</summary>
        public XmlSerializer() {
            this._Serializer = new XmlSerializer(typeof(TypeSerialize));
        }
    }
}