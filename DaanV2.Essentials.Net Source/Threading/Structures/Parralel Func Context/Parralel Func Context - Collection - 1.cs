/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Collections.Generic;

namespace DaanV2.Threading {
    /// <summary>The context needed to perform a Parallel action over an array of type <typeparamref name="T"/>.</summary>
    internal partial struct ParallelFuncContextCollection<T, U> {
        /// <summary>The index to start from.</summary>
        public Int32 _StartIndex;

        /// <summary>The index to stop.</summary>
        public Int32 _EndIndex;

        /// <summary>The action perform on the array's items.</summary>
        public IList<T> _Items;

        /// <summary>The action to perform on each item.</summary>
        public Func<T, U> _Action;

        /// <summary></summary>
        public U[] _Receiver;

        /// <summary>Very backwards but <see cref="System.Threading.Task"/> does not accept functions with inputs. Possibly because state  like this need to be crated</summary>
        public void Invoke() {
            //Run action
            Parallel.Func.ForEachInternal(this);
        }
    }
}
