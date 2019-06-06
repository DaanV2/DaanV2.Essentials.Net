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

namespace DaanV2.Converters {
    ///DOLATER <summary> add description for interface: IConverter</summary>
    ///DOLATER <typeparam name="TypeFrom"></typeparam>
    ///DOLATER <typeparam name="TypeTo"></typeparam>
    public interface IConverterInto<TypeFrom, TypeTo> {
        ///DOLATER <summary>Add Description</summary>
        /// <param name="Process"></param>
        /// <returns></returns>
        void Convert(TypeFrom Process, TypeTo Into);
    }
}
