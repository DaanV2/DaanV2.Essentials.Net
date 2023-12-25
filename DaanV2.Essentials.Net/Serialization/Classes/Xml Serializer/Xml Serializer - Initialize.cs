
using System.Xml.Serialization;

namespace DaanV2.Serialization {
    /// <summary>A class that contects the build in JSON serializer from .Net into the <see cref="Serialization"/>.</summary>
    /// <typeparam name="T">The type to serializer/deserialize.</typeparam>
    [Serializer("xml"), Deserializer("xml")]
    public partial class XmlSerializer<T> {

        /// <summary>Creates a new instance of <see cref="XmlSerializer{T}"/>.</summary>
        public XmlSerializer() {
            this._Serializer = new XmlSerializer(typeof(T));
        }
    }
}