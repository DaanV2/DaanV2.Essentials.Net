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
using System;
using System.Collections.Generic;

namespace DaanV2 {
    public partial class PriorityAttributeComparer : IComparer<Object> {
        /// <summary>Compares two object to each other, retrieves the priority attribute from them.</summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        /// <returns>Compares two object to each other, retrieves the priority attribute from them.</returns>
        public Int32 Compare(Object x, Object y) {
            Type Tx = x.GetType();
            Type Ty = y.GetType();

            PriorityAttribute PAx = Tx.GetAttribute<PriorityAttribute>();
            PriorityAttribute PAy = Ty.GetAttribute<PriorityAttribute>();

            return PAx == null || PAy == null ?
                Tx.Name.CompareTo(Ty.Name) :
                PAx.Value.CompareTo(PAy.Value);
        }
    }
}
