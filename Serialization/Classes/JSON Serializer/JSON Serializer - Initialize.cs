using System;
using System.Runtime.Serialization;

namespace DaanV2.Serialization {
    /// <summary>A class that contects the build in JSON serializer from .Net into the <see cref="Serialization"/></summary>
    /// <typeparam name="TypeSerialize">The type to serializer/deserialize</typeparam>
	[Serializable, DataContract]
    [Serializer("json"), Deserializer("json")]
    public partial class JSONSerializer<TypeSerialize> {

        /// <summary>Creates a new instance of <see cref="JSONSerializer"/></summary>
        public JSONSerializer() {
            this.serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(TypeSerialize));
        }
    }
}
