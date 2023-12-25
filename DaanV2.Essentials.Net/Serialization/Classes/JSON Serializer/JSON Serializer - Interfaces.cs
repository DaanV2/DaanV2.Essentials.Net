using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace DaanV2.Serialization {
    public partial class JSONSerializer<T> :
        ISerializer<T, Stream>,
        IDeserializer<T, Stream> {

        /// <summary>Deserialize the given stream into the specified <see cref="Type"/>.</summary>
        /// <param name="stream">The stream to read from.</param>
        /// <returns>Deserialize the given stream into the specified <see cref="Type"/>.</returns>
        public T Deserialize([NotNull] Stream stream) {
            ValueTask<T> Out = JsonSerializer.DeserializeAsync<T>(stream, this._Options);

            Out.AsTask().Wait();

            return Out.Result;
        }

        /// <summary>Serializes the given object into the given stream.</summary>
        /// <param name="O">The object to serialize.</param>
        /// <param name="stream">The stream to write to.</param>
        public void Serialize([NotNull] T O, [NotNull] Stream stream) {
            Task Out = JsonSerializer.SerializeAsync(stream, O, this._Options);
            Out.Wait();
        }
    }
}