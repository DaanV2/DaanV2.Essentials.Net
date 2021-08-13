/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;

namespace DaanV2.Threading {
    /// <summary>The context needed to perform a Parallel action over an array of type <typeparamref name="T1"/>.</summary>
    internal partial struct ParallelContext<T1, T2> {
        /// <summary>Creates a new instance of <see cref="ParallelContext{T1, T2}"/>.</summary>
        /// <param name="StartIndex">The index to start at.</param>
        /// <param name="EndIndex">The index to stop.</param>
        /// <param name="Items">The array to loop over.</param>
        /// <param name="action">The action to perform on each item.</param>
        /// <param name="Argument1">The context argument to pass along.</param>
        public ParallelContext(Int32 StartIndex, Int32 EndIndex, T1[] Items, Action<T1, T2> action, T2 Argument1) {
            this._StartIndex = StartIndex;
            this._EndIndex = EndIndex;
            this._Items = Items;
            this._Action = action;
            this._Argument1 = Argument1;
        }

        /// <summary>The index to start from.</summary>
        public Int32 _StartIndex;

        /// <summary>The index to stop.</summary>
        public Int32 _EndIndex;

        /// <summary>The array to loop through.</summary>
        public T1[] _Items;

        /// <summary>The action perform on the array's items.</summary>
        public Action<T1, T2> _Action;

        /// <summary>The argument to pass along as context.</summary>
        public T2 _Argument1;

        /// <summary>Invokes the foreach to be performend on this instance</summary>
        public void Invoke() {
            Parallel.ForEachInternal(this);
        }
    }
}
