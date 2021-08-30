﻿/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;

namespace DaanV2.Threading {
    /// <summary>The context needed to perform a Parallel action over an array of type <typeparamref name="T"/>.</summary>
    internal partial struct ParallelContext<T> {
        /// <summary>Creates a new instance of <see cref="ParallelContext{T}"/>.</summary>
        /// <param name="StartIndex">The index to start at.</param>
        /// <param name="EndIndex">The index to stop.</param>
        /// <param name="Items">The array to loop over.</param>
        /// <param name="action">The action to perform on each item.</param>
        public ParallelContext(Int32 StartIndex, Int32 EndIndex, T[] Items, Action<T> action) {
            this._StartIndex = StartIndex;
            this._EndIndex = EndIndex;
            this._Items = Items;
            this._Action = action;
        }

        /// <summary>The index to start from.</summary>
        public Int32 _StartIndex;

        /// <summary>The index to stop.</summary>
        public Int32 _EndIndex;

        /// <summary>The array to loop through.</summary>
        public T[] _Items;

        /// <summary>The action to perform on each item.</summary>
        public Action<T> _Action;

        /// <summary>Invokes the foreach to be performend on this instance</summary>
        public void Invoke() {
            Parallel.ForEachInternal(this);
        }
    }
}