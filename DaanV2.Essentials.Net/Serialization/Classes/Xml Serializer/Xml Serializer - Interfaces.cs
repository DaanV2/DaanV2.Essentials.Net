using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace DaanV2.Serialization {
    public partial class XmlSerializer<T> : ISerializer<T, Stream>, IDeserializer<T, Stream> {
        /// <inheritdoc/>
        public T Deserialize([NotNull] Stream Reader) {
            return (T)this._Serializer.Deserialize(Reader);
        }

        /// <inheritdoc/>
        public void Serialize([NotNull] T O, [NotNull] Stream Reader) {
            this._Serializer.Serialize(Reader, O);
        }
    }
}