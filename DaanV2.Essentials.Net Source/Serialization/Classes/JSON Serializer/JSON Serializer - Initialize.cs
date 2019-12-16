/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.


THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS.IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;
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
            this._Serializer = new DataContractJsonSerializer(typeof(TypeSerialize));
#endif
        }
    }
}
