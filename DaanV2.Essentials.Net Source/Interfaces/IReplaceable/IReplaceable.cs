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

namespace DaanV2 {
    /// <summary>The interface responsible replacing the specified value with another.</summary>
    /// <typeparam name="T">The old and new type to replace.</typeparam>
    public interface IReplaceable<T> : IReplaceable<T, T> {
    }

    /// <summary>The interface responsible replacing the specified value with another.</summary>
    /// <typeparam name="TypeOld">The old type.</typeparam>
    /// <typeparam name="TypeNew">The new type.</typeparam>
    public interface IReplaceable<TypeOld, TypeNew> {
        /// <summary>Replaces the old value with the new value.</summary>
        /// <param name="OldValue">The old value to replace.</param>
        /// <param name="NewValue">The new value to insert.</param>
        void Replace(TypeOld OldValue, TypeNew NewValue);
    }
}
