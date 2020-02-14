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

namespace DaanV2.Builders {
    /// <summary>A subpart of a <see cref="IBuilder{TypeToBuild, TIn}"/> that specifies if a different object can be added with context.</summary>
    public interface IBuilderAddContext<TypeToAdd, ContextType> {
        /// <summary>Adds the specific object to the build.</summary>
        /// <param name="O">The object to check if it can be added.</param>
        /// <param name="Context">The relevant context needed to possibly help identify the object.</param>
        void Add(TypeToAdd O, ContextType Context);
    }
}
