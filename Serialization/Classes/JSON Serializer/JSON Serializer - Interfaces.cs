using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Serialization {
    public partial class JSONSerializer<TypeSerialize> : 
        ISerializer<TypeSerialize, Stream>,
        IDeserializer<TypeSerialize, Stream> {

        ///DOLATER <summary>Add Description</summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public TypeSerialize Deserialize(Stream stream) {
            return (TypeSerialize)this.serializer.ReadObject(stream);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="O"></param>
        /// <param name="stream"></param>
        public void Serialize(TypeSerialize O, Stream stream) {
            this.serializer.WriteObject(stream, O);
        }
    }
}
