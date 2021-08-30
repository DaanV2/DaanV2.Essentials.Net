/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Text.Json;

namespace DaanV2.Serialization {
    public partial class JSONSerializer<TypeSerialize> {
        /// <summary>The options to be used when generating a serializer.</summary>
        [NonSerialized]
        private protected JsonSerializerOptions _Options;
    }
}
