/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Threading.Tasks;

namespace DaanV2.Threading {
    public static partial class Parallel {
        /// <summary>Loops over each item in the specified array.</summary>
        /// <typeparam name="T">The type inside the array.</typeparam>
        /// <param name="Items">The items to loop over.</param>
        /// <param name="action">The action to preform on each item.</param>
        /// <returns>Loops over each item in the specified array.</returns>
        public static Task[] ForEach<T>(T[] Items, Action<T> action) {
            return ForEach(Items, action, Environment.ProcessorCount);
        }

        /// <summary>Loops over each item in the specified array.</summary>
        /// <typeparam name="T">The type inside the array.</typeparam>
        /// <param name="Items">The items to loop over.</param>
        /// <param name="action">The action to preform on each item.</param>
        /// <param name="TaskCount">The amount of tasks that should process over this array.</param>
        /// <returns>Loops over each item in the specified array.</returns>
        public static Task[] ForEach<T>(T[] Items, Action<T> action, Int32 TaskCount) {
            if (TaskCount < 1) {
                throw new ArgumentOutOfRangeException(nameof(TaskCount));
            }

            var Out = new Task[TaskCount];

            Int32 Step = Items.Length / TaskCount;
            Int32 Max = TaskCount - 1;

            //Creates sections and start
            for (Int32 I = 0; I < Max; I++) {
                var Context = new ParallelContext<T>(I * Step, (I + 1) * Step, Items, action);
                Out[I] = Task.Factory.StartNew(Context.Invoke);
            }

            //Creates the last
            var Context1 = new ParallelContext<T>(Max * Step, Items.Length, Items, action);
            Out[Max] = Task.Factory.StartNew(Context1.Invoke);

            return Out;
        }

        /// <summary>Loops over each item in the specified array.</summary>
        /// <typeparam name="T">The type inside the array.</typeparam>
        /// <typeparam name="T1">The type used for the additional information.</typeparam>
        /// <param name="Items">The items to loop over.</param>
        /// <param name="action">The action to preform on each item.</param>
        /// <param name="Argument">The object needed to process each other object.</param>
        /// <returns>Loops over each item in the specified array.</returns>
        public static Task[] ForEach<T, T1>(T[] Items, Action<T, T1> action, T1 Argument) {
            return ForEach(Items, action, Argument, Environment.ProcessorCount);
        }

        /// <summary>Loops over each item in the specified array.</summary>
        /// <typeparam name="T">The type inside the array.</typeparam>
        /// <typeparam name="T1">The type used for the additional information.</typeparam>
        /// <param name="Items">The items to loop over.</param>
        /// <param name="action">The action to preform on each item.</param>
        /// <param name="Argument">The object needed to process each other object.</param>
        /// <param name="TaskCount">The amount of tasks that should process over this array.</param>
        /// <returns>Loops over each item in the specified array.</returns>
        public static Task[] ForEach<T, T1>(T[] Items, Action<T, T1> action, T1 Argument, Int32 TaskCount) {
            if (TaskCount < 1) {
                throw new ArgumentOutOfRangeException(nameof(TaskCount));
            }

            var Out = new Task[TaskCount];

            Int32 Step = Items.Length / Out.Length;
            Int32 Max = Out.Length - 1;

            for (Int32 I = 0; I < Max; I++) {
                var Context = new ParallelContext<T, T1>(I * Step, (I + 1) * Step, Items, action, Argument);
                Out[I] = Task.Factory.StartNew(Context.Invoke);
            }

            var Context1 = new ParallelContext<T, T1>(Max * Step, Items.Length, Items, action, Argument);
            Out[Max] = Task.Factory.StartNew(Context1.Invoke);

            return Out;
        }
    }
}
