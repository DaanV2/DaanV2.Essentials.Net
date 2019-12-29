/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.


THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/

namespace DaanV2.Serialization {
    /// <summary>The interface that is responsible for forming the contract on how Deserializer should work</summary>
    /// <typeparam name="TypeOut">The type to be returned after deserializing</typeparam>
    /// <typeparam name="TypeStream">The type of the stream to be used</typeparam>
    /// <typeparam name="TypeContext">The context needed for deserializing</typeparam>
    public interface IDeserializer<TypeOut, TypeStream, TypeContext> {

        /// <summary>Deserializer the given stream into the specified type</summary>
        /// <param name="stream">The stream to read from</param>
        /// <param name="Context">The context needed to read the stream</param>
        /// <returns>Deserializer the given stream into the specified type</returns>
        TypeOut Deserialize(TypeStream stream, TypeContext Context);
    }
}
