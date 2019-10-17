﻿using System;
using System.Runtime.Serialization;
#if NETCORE
using System.Text.Json;
#else
using System.Runtime.Serialization.Json;
#endif

namespace DaanV2.Serialization {
    /// <summary>A class that contects the build in JSON serializer from .Net into the <see cref="Serialization"/></summary>
    /// <typeparam name="TypeSerialize">The type to serializer/deserialize</typeparam>
	[Serializable, DataContract]
    [Serializer("json"), Deserializer("json")]
    public partial class JSONSerializer<TypeSerialize> {

        /// <summary>Creates a new instance of <see cref="JSONSerializer"/></summary>
        public JSONSerializer() {
#if NETCORE
            this._Options = new JsonSerializerOptions {
                AllowTrailingCommas = false,
                IgnoreNullValues = true,
                IgnoreReadOnlyProperties = true,
                ReadCommentHandling = JsonCommentHandling.Skip,
                WriteIndented = true
            };
#else
            this.serializer = new DataContractJsonSerializer(typeof(TypeSerialize));
#endif
        }
    }
}
