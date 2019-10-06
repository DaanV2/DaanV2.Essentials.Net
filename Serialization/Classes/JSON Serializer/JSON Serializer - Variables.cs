using System;
using System.Runtime.Serialization.Json;

namespace DaanV2.Serialization {
    public partial class JSONSerializer<TypeSerialize> {

        /// <summary>The underlying serializer that is being connected to the interface</summary>
        [NonSerialized]
        private DataContractJsonSerializer serializer;
    }
}
