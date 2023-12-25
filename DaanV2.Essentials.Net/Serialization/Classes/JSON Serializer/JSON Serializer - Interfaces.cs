using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace DaanV2.Serialization {
    public partial class JSONSerializer<T> :
        ISerializer<T, Stream>,
        IDeserializer<T, Stream> {

        /// <summary>Deserialize the given writer into the specified <see cref="Type"/>.</summary>
        /// <param name="reader">The stream to read from.</param>
        /// <returns>Deserialize the given writer into the specified <see cref="Type"/>.</returns>
        public T Deserialize([NotNull] Stream reader) {
            ValueTask<T> Out = JsonSerializer.DeserializeAsync<T>(reader, this._Options);

            Out.AsTask().Wait();

            return Out.Result;
        }

        /// <summary>Serializes the given object into the given writer.</summary>
        /// <param name="O">The object to serialize.</param>
        /// <param name="writer">The writer to write to.</param>
        public void Serialize([NotNull] T O, [NotNull] Stream writer) {
            Task Out = JsonSerializer.SerializeAsync(writer, O, this._Options);
            Out.Wait();
        }
    }
}