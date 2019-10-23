using System;
#if NETCORE
using System.Text.Json;
#else
using System.Runtime.Serialization.Json;
#endif

namespace DaanV2.Serialization {
    public partial class JSONSerializer<TypeSerialize> {
#if NETCORE

        ///DOLATER <summary>Add Description</summary>
        [NonSerialized]
        private protected JsonSerializerOptions _Options;
#else

        /// <summary>The underlying serializer that is being connected to the interface</summary>
        [NonSerialized]
        private protected DataContractJsonSerializer _Serializer;
#endif

    }
}
