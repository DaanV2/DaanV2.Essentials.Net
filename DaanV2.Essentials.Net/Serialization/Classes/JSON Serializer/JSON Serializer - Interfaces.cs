/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace DaanV2.Serialization {
    public partial class JSONSerializer<TypeSerialize> :
        ISerializer<TypeSerialize, Stream>,
        IDeserializer<TypeSerialize, Stream> {

        /// <summary>Deserialize the given stream into the specified <see cref="Type"/>.</summary>
        /// <param name="stream">The stream to read from.</param>
        /// <returns>Deserialize the given stream into the specified <see cref="Type"/>.</returns>
        public TypeSerialize Deserialize(Stream stream) {
            ValueTask<TypeSerialize> Out = JsonSerializer.DeserializeAsync<TypeSerialize>(stream, this._Options);

            Out.AsTask().Wait();

            return Out.Result;
        }

        /// <summary>Serializes the given object into the given stream.</summary>
        /// <param name="O">The object to serialize.</param>
        /// <param name="stream">The stream to write to.</param>
        public void Serialize(TypeSerialize O, Stream stream) {
            Task Out = JsonSerializer.SerializeAsync(stream, O, this._Options);
            Out.Wait();
        }
    }
}
