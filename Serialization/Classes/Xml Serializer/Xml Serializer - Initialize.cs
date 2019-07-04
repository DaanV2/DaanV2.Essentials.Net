using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Serialization {
    /// <summary>A class that contects the build in JSON serializer from .Net into the <see cref="Serialization"/></summary>
    /// <typeparam name="TypeSerialize">The type to serializer/deserialize</typeparam>
	[Serializable, DataContract]
    [Serializer("xml"), Deserializer("xml")]
    public partial class XmlSerializer<TypeSerialize> {

        /// <summary>Creates a new instance of <see cref="XmlSerializer"/></summary>
        public XmlSerializer() {
            this.Serializer = new System.Xml.Serialization.XmlSerializer(typeof(TypeSerialize));
        }
    }
}
