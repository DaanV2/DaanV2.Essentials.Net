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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Builders {
    /// <summary>The specification how a builder should function</summary>
    public interface IBuilder<TypeToBuild> {
        /// <summary>Adds the specific object to the build</summary>
        /// <param name="O">The object to add</param>
        void Add(Object O);

        /// <summary>Checks if the given object can be added to the builder</summary>
        /// <param name="O">The object to check</param>
        /// <returns>A <see cref="Boolean"/></returns>
        Boolean CanAccept(Object O);

        /// <summary>Set the base object of this builder to work on</summary>
        /// <param name="Base">The base object</param>
        void SetBase(TypeToBuild Base);

        /// <summary>Returns the builded version of the specified <see cref="TypeToBuild"/></summary>
        /// <returns>A <see cref="TypeToBuild"/></returns>
        TypeToBuild BuildFinal();
    }
}
