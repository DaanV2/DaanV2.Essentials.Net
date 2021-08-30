/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System.Text.Json;

namespace DaanV2.Serialization {
    /// <summary>A class that contects the build in JSON serializer from .Net into the <see cref="Serialization"/>.</summary>
    /// <typeparam name="TypeSerialize">The type to serializer/deserialize.</typeparam>
    [Serializer("json"), Deserializer("json")]
    public partial class JSONSerializer<TypeSerialize> {

        /// <summary>Creates a new instance of <see cref="JSONSerializer{TypeSerialize}"/>.</summary>
        public JSONSerializer() {
            this._Options = new JsonSerializerOptions {
                AllowTrailingCommas = false,
                IgnoreNullValues = true,
                IgnoreReadOnlyProperties = true,
                ReadCommentHandling = JsonCommentHandling.Skip,
                WriteIndented = true
            };
        }
    }
}
