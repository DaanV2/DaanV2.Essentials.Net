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

namespace DaanV2.Processors {
    /// <summary>The interface responsible for forming the contract on how Pre processors should work</summary>
    /// <typeparam name="T">The type of object to pre process</typeparam>
    /// <typeparam name="TypeContext">The type of object used as context</typeparam>
    public interface IPreProcessor<T, TypeContext> {
        /// <summary>Pre processes the given object</summary>
        /// <param name="Process">The object to pre process</param>
        /// <param name="Context">The context used to pre process</param>
        void Preprocess(T Process, TypeContext Context);
    }
}
