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

namespace DaanV2.Builders {
    /// <summary>The interface that responsible for building a specified class with/without context</summary>
    /// <typeparam name="TypeBuild">The type to build to</typeparam>
    /// <typeparam name="ContextType">The context type</typeparam>
    public interface IBuilder<TypeToBuild, ContextType> : IBuilder<TypeToBuild> {

        /// <summary>Adds the specific object to the build</summary
        /// <param name="O">The object to check if it can be added</param>
        /// <param name="Context">The relevant context needed to possibly help identify the object</param>
        /// <returns>A <see cref="Boolean"/></returns>
        void Add(Object O, ContextType Context);

        /// <summary>Return true/false whenever the given object is able to be added to this build</summary>
        /// <param name="O">The object to check if it can be added</param>
        /// /// <param name="Context">The relevant context needed to possibly help identify the object</param>
        /// <returns>A <see cref="Boolean"/></returns>
        Boolean CanAccept(Object O, ContextType Context);
    }
}
