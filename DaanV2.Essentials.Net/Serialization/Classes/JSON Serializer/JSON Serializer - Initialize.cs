using System.Text.Json;
using System.Text.Json.Serialization;

namespace DaanV2.Serialization {
    /// <summary>A class that contects the build in JSON serializer from .Net into the <see cref="Serialization"/>.</summary>
    /// <typeparam name="T">The type to serializer/deserialize.</typeparam>
    [Serializer("json"), Deserializer("json")]
    public partial class JSONSerializer<T> {

        /// <summary>Creates a new instance of <see cref="JSONSerializer{T}"/>.</summary>
        public JSONSerializer() {
            this._Options = new JsonSerializerOptions {
                AllowTrailingCommas = false,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                IgnoreReadOnlyProperties = true,
                ReadCommentHandling = JsonCommentHandling.Skip,
                WriteIndented = true
            };
        }
    }
}