using System;
#if NETCORE
using System.Text.Json;
#else
using System.Runtime.Serialization.Json;
#endif

namespace DaanV2.Serialization {
    public partial class JSONSerializer<TypeSerialize> {
#if NETCORE

        /// <summary></summary>
        [NonSerialized]
        private JsonSerializerOptions _Options;
#else

        /// <summary>The underlying serializer that is being connected to the interface</summary>
        [NonSerialized]
        private DataContractJsonSerializer _Serializer;
#endif
        
    }
}
