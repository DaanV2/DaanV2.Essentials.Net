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

namespace DaanV2.Converters {
    /// <summary>The interface responsible for forming the contract on how Converter should work with context</summary>
    /// <typeparam name="TypeFrom">The object to convert into the specified type</typeparam>
    /// <typeparam name="TypeTo">The type that is returned after conversion</typeparam>
    /// <typeparam name="TypeContext">The type of the context</typeparam>
    public interface IConverterInto<TypeFrom, TypeTo, TypeContext> {

        /// <summary>Convert the given object into the specified type</summary>
        /// <param name="Process">The object to convert</param>
        /// <param name="Context">The context needed to convert the given object</param>
        /// <param name="Into">The object that receives the converted object</param>
        void Convert(TypeFrom Process, TypeContext Context, TypeTo Into);
    }
}
