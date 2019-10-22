using System;
using System.IO;

namespace DaanV2.Serialization {
    public partial class JSONSerializer<TypeSerialize> :
        ISerializer<TypeSerialize, Stream>,
        IDeserializer<TypeSerialize, Stream> {


#if NETCORE
        /// <summary>Deserialize the given stream into the specified <see cref="Type"/></summary>
        /// <param name="stream">FILL_ME_IN</param>
        ///DOLATER <returns></returns>
        public TypeSerialize Deserialize(Stream stream) {
            System.Threading.Tasks.ValueTask<TypeSerialize> Out =
                System.Text.Json.JsonSerializer.DeserializeAsync<TypeSerialize>(stream, this._Options);
            Out.AsTask().Wait();

            return Out.Result;
        }

        /// <summary>Serializes the given object into the given stream</summary>
        /// <param name="O">FILL_ME_IN</param>
        /// <param name="stream">FILL_ME_IN</param>
        public void Serialize(TypeSerialize O, Stream stream) {
            System.Threading.Tasks.Task Out =
                System.Text.Json.JsonSerializer.SerializeAsync(stream, O, this._Options);
            Out.Wait();
        }
#else
        /// <summary>Deserialize the given stream into the specified <see cref="Type"/></summary>
        /// <param name="stream">FILL_ME_IN</param>
        ///DOLATER <returns></returns>
        public TypeSerialize Deserialize(Stream stream) {
            return (TypeSerialize)this._Serializer.ReadObject(stream);
        }

        /// <summary>Serializes the given object into the given stream</summary>
        /// <param name="O">FILL_ME_IN</param>
        /// <param name="stream">FILL_ME_IN</param>
        public void Serialize(TypeSerialize O, Stream stream) {
            this._Serializer.WriteObject(stream, O);
        }
#endif

    }
}
