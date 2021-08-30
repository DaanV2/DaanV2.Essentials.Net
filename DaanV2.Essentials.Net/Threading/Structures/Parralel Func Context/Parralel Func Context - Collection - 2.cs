/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Collections.Generic;

namespace DaanV2.Threading {
    /// <summary>The context needed to perform a Parallel action over an array of type <typeparamref name="T1"/>.</summary>
    internal partial struct ParallelFuncContextCollection<T1, T2, U> {
        /// <summary>The index to start from.</summary>
        public Int32 _StartIndex;

        /// <summary>The index to stop.</summary>
        public Int32 _EndIndex;

        /// <summary>The array to loop through.</summary>
        public IList<T1> _Items;

        /// <summary>The action to perform on each item.</summary>
        public Func<T1, T2, U> _Action;

        /// <summary></summary>
        public U[] _Receiver;

        /// <summary>The argument to pass along as context.</summary>
        public T2 _Argument1;

        /// <summary>Very backwards but <see cref="System.Threading.Tasks.Task"/> does not accept functions with inputs. Possibly because state  like this need to be crated</summary>
        public void Invoke() {
            //Run action
            Parallel.Func.ForEachInternal(this);
        }
    }
}
