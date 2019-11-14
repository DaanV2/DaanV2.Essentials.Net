﻿/*ISC License

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

namespace DaanV2 {
    ///DOLATER <summary> add description for interface: IReplaceable</summary>
    /// <typeparam name="T"></typeparam>
    public interface IReplaceable<T> : IReplaceable<T, T> {
    }

    ///DOLATER <summary> add description for interface: IReplaceable</summary>
    /// <typeparam name="TypeOld"></typeparam>
    /// <typeparam name="TypeNew"></typeparam>
    public interface IReplaceable<TypeOld, TypeNew>
    {
        ///DOLATER <summary>Add Description</summary>
        /// <param name="Old">FILL_ME_IN</param>
        /// <param name="NewValue">FILL_ME_IN</param>
        void Replace(TypeOld OldValue, TypeNew NewValue);
    }
}
