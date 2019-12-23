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
    /// <summary>The interface that is responsible for forming the contract on how serializers should behave</summary>
    /// <typeparam name="TypeIn">The type that is being serializied</typeparam>
    /// <typeparam name="TypeStream">The stream type used to write the given type</typeparam>
    /// <typeparam name="TypeContext">The context needed to serialize the given type</typeparam>
    public interface ISerializer<TypeIn, TypeStream, TypeContext> {

        /// <summary>Serializes the given object into the given stream along with the context needed to serialize</summary>
        /// <param name="O">The object to serialize</param>
        /// <param name="stream">The stream to write the given object into</param>
        /// <param name="Context">The context that is needed to the serialize the given object</param>
        void Serialize(TypeIn O, TypeStream stream, TypeContext Context);
    }
}
