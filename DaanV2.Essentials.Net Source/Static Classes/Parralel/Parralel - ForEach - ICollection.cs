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
using System.Threading.Tasks;

namespace DaanV2 {
    /// <summary>The class that creates Parallel tasks.</summary>
    public static partial class Parallel {
        /// <summary>Loops over each item in the specified <see cref="ICollection{T}" />.</summary>
        /// <typeparam name="T">The type inside the <see cref="ICollection{T}" />.</typeparam>
        /// <param name="Items">The items to loop over.</param>
        /// <param name="action">The action to preform on each item.</param>
        /// <returns>Loops over each item in the specified <see cref="ICollection{T}" />.</returns>
        public static Task[] ForEach<T>(ICollection<T> Items, Action<T> action) {
            Task[] Out = new Task[Environment.ProcessorCount];

            Int32 Step = Items.Count / Out.Length;
            Int32 Max = Out.Length - 1;
            Action<Object> InternalAction = (x) => {
                Parallel.ForEachInternal((ParallelContext<T>)x);
            };

            for (Int32 I = 0; I < Max; I++) {
                ParallelContextCollection<T> Context = new ParallelContextCollection<T>(I * Step, (I + 1) * Step, Items, action);
                Out[I] = Task.Factory.StartNew(InternalAction, Context);
            }

            ParallelContextCollection<T> Context1 = new ParallelContextCollection<T>(Max * Step, Items.Count, Items, action);
            Out[Max] = Task.Factory.StartNew(InternalAction, Context1);

            return Out;
        }

        /// <summary>Loops over each item in the specified <see cref="ICollection{T}" />.</summary>
        /// <typeparam name="T">The type inside the <see cref="ICollection{T}" />.</typeparam>
        /// <param name="Items">The items to loop over.</param>
        /// <param name="action">The action to preform on each item.</param>
        /// <param name="TaskCount">The amount of tasks that should process over this <see cref="ICollection{T}" />.</param>
        /// <returns>Loops over each item in the specified <see cref="ICollection{T}" />.</returns>
        public static Task[] ForEach<T>(ICollection<T> Items, Action<T> action, Int32 TaskCount) {
            if (TaskCount < 1)
                throw new ArgumentOutOfRangeException(nameof(TaskCount));

            Task[] Out = new Task[TaskCount];

            Int32 Step = Items.Count / Out.Length;
            Int32 Max = Out.Length - 1;
            Action<Object> InternalAction = (x) => {
                Parallel.ForEachInternal((ParallelContext<T>)x);
            };

            for (Int32 I = 0; I < Max; I++) {
                ParallelContextCollection<T> Context = new ParallelContextCollection<T>(I * Step, (I + 1) * Step, Items, action);
                Out[I] = Task.Factory.StartNew(InternalAction, Context);
            }

            ParallelContextCollection<T> Context1 = new ParallelContextCollection<T>(Max * Step, Items.Count, Items, action);
            Out[Max] = Task.Factory.StartNew(InternalAction, Context1);

            return Out;
        }

        /// <summary>Loops over each item in the specified <see cref="ICollection{T}"/>.</summary>
        /// <typeparam name="T">The type inside the <see cref="ICollection{T}"/>.</typeparam>
        /// <typeparam name="T1">The additional argument type.</typeparam>
        /// <param name="Items">The items to loop over.</param>
        /// <param name="action">The action to preform on each item.</param>
        /// <param name="Argument">The additional argument needed to process the item.</param>
        /// <returns>Loops over each item in the specified <see cref="ICollection{T}" />.</returns>
        public static Task[] ForEach<T, T1>(ICollection<T> Items, Action<T, T1> action, T1 Argument) {
            Task[] Out = new Task[Environment.ProcessorCount];

            Int32 Step = Items.Count / Out.Length;
            Int32 Max = Out.Length - 1;
            Action<Object> InternalAction = (x) => {
                Parallel.ForEachInternal((ParallelContext<T, T1>)x);
            };

            for (Int32 I = 0; I < Max; I++) {
                ParallelContextCollection<T, T1> Context = new ParallelContextCollection<T, T1>(I * Step, (I + 1) * Step, Items, action, Argument);
                Out[I] = Task.Factory.StartNew(InternalAction, Context);
            }

            ParallelContextCollection<T, T1> Context1 = new ParallelContextCollection<T, T1>(Max * Step, Items.Count, Items, action, Argument);
            Out[Max] = Task.Factory.StartNew(InternalAction, Context1);

            return Out;
        }

        /// <summary>Loops over each item in the specified <see cref="ICollection{T}" />.</summary>
        /// <typeparam name="T">The type inside the <see cref="ICollection{T}" />.</typeparam>
        /// <typeparam name="T1">The additional argument type.</typeparam>
        /// <param name="Items">The items to loop over.</param>
        /// <param name="action">The action to preform on each item.</param>
        /// <param name="TaskCount">The amount of tasks that should process over this <see cref="ICollection{T}" />.</param>
        /// <param name="Argument">The additional argument needed to process the item.</param>
        /// <returns>Loops over each item in the specified <see cref="ICollection{T}" />.</returns>
        public static Task[] ForEach<T, T1>(ICollection<T> Items, Action<T, T1> action, T1 Argument, Int32 TaskCount) {
            if (TaskCount < 1)
                throw new ArgumentOutOfRangeException(nameof(TaskCount));

            Task[] Out = new Task[Environment.ProcessorCount];

            Int32 Step = Items.Count / Out.Length;
            Int32 Max = Out.Length - 1;
            Action<Object> InternalAction = (x) => {
                Parallel.ForEachInternal((ParallelContext<T, T1>)x);
            };

            for (Int32 I = 0; I < Max; I++) {
                ParallelContextCollection<T, T1> Context = new ParallelContextCollection<T, T1>(I * Step, (I + 1) * Step, Items, action, Argument);
                Out[I] = Task.Factory.StartNew(InternalAction, Context);
            }

            ParallelContextCollection<T, T1> Context1 = new ParallelContextCollection<T, T1>(Max * Step, Items.Count, Items, action, Argument);
            Out[Max] = Task.Factory.StartNew(InternalAction, Context1);

            return Out;
        }
    }
}
