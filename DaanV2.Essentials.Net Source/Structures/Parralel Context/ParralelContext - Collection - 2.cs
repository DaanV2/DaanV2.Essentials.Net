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
    /// <summary>The context needed to perform a Parallel action over an array of type <typeparamref name="T1"/></summary>
    internal partial struct ParallelContextCollection<T1, T2> {
        /// <summary>Creates a new instance of <see cref="ParallelContext{T1, T2}"/></summary>
        /// <param name="StartIndex">The index to start at</param>
        /// <param name="EndIndex">The index to stop</param>
        /// <param name="Items">The array to loop over</param>
        /// <param name="action">The action to perform on each item</param>
        /// <param name="Argument1">The context argument to pass along</param>
        public ParallelContextCollection(Int32 StartIndex, Int32 EndIndex, ICollection<T1> Items, Action<T1, T2> action, T2 Argument1) {
            this._StartIndex = StartIndex;
            this._EndIndex = EndIndex;
            this._Items = Items;
            this._Action = action;
            this._Argument1 = Argument1;
        }

        /// <summary>The index to start from</summary>
        public Int32 _StartIndex;

        /// <summary>The index to stop</summary>
        public Int32 _EndIndex;

        /// <summary>The array to loop through</summary>
        public ICollection<T1> _Items;

        /// <summary>The action perform on the array's items</summary>
        public Action<T1, T2> _Action;

        /// <summary>The argument to pass along as context</summary>
        public T2 _Argument1;
    }
}
