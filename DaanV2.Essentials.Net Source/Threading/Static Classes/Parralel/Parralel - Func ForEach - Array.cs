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

namespace DaanV2.Threading {
    public static partial class Parallel {
        public static partial class Func {
            /// <summary>Loops over each item in the specified array.</summary>
            /// <typeparam name="T">The type inside the array.</typeparam>
            /// <typeparam name="U">The type to be outputted</typeparam>
            /// <param name="Items">The items to loop over.</param>
            /// <param name="action">The action to preform on each item.</param>
            /// <returns>Loops over each item in the specified array.</returns>
            public static FuncResult<U> ForEach<T, U>(T[] Items, Func<T, U> action) {
                return ForEach(Items, action, Environment.ProcessorCount);
            }

            /// <summary>Loops over each item in the specified array.</summary>
            /// <typeparam name="T">The type inside the array.</typeparam>
            /// <typeparam name="U">The type to be outputted</typeparam>
            /// <param name="Items">The items to loop over.</param>
            /// <param name="action">The action to preform on each item.</param>
            /// <param name="TaskCount">The amount of tasks that should process over this array.</param>
            /// <returns>Loops over each item in the specified array.</returns>
            public static FuncResult<U> ForEach<T, U>(T[] Items, Func<T, U> action, Int32 TaskCount) {
                if (TaskCount < 1) {
                    throw new ArgumentOutOfRangeException(nameof(TaskCount));
                }

                Int32 Length = Items.Length;
                var Receiver = new U[Length];
                var Tasks = new Task[TaskCount];

                Int32 Step = Length / TaskCount;
                Int32 Max = TaskCount - 1;                

                //Creates sections and start
                for (Int32 I = 0; I < Max; I++) {
                    //Creates the context for this section
                    var Context = new ParallelFuncContext<T, U>() {
                        _StartIndex = I * Step,
                        _EndIndex = (I + 1) * Step,
                        _Items = Items,
                        _Action = action,
                        _Receiver = Receiver
                    };

                    Tasks[I] = Task.Factory.StartNew(Context.Invoke);
                }

                //Creates the last section to process
                Int32 Start = Max * Step;
                var Context1 = new ParallelFuncContext<T, U>() {
                    _StartIndex = Start,
                    _EndIndex = Length,
                    _Items = Items,
                    _Action = action,
                    _Receiver = Receiver
                };

                Tasks[Max] = Task.Factory.StartNew(Context1.Invoke);

                return new FuncResult<U>(Tasks, Receiver);
            }

            /// <summary>Loops over each item in the specified array.</summary>
            /// <typeparam name="T1">The type inside the array.</typeparam>
            /// <typeparam name="T2">The type used for the additional information.</typeparam>
            /// <typeparam name="U">The type to be outputted</typeparam>
            /// <param name="Items">The items to loop over.</param>
            /// <param name="Argument1">The first argument1</param>
            /// <param name="action">The action to preform on each item.</param>
            /// <returns>Loops over each item in the specified array.</returns>
            public static FuncResult<U> ForEach<T1, T2, U>(T1[] Items, T2 Argument1, Func<T1, T2, U> action) {
                return ForEach(Items, Argument1, action, Environment.ProcessorCount);
            }

            /// <summary>Loops over each item in the specified array.</summary>
            /// <typeparam name="T1">The type inside the array.</typeparam>
            /// <typeparam name="T2">The type used for the additional information.</typeparam>
            /// <typeparam name="U">The type to be outputted</typeparam>
            /// <param name="Items">The items to loop over.</param>
            /// <param name="Argument1">The first argument1</param>
            /// <param name="action">The action to preform on each item.</param>
            /// <param name="TaskCount">The amount of tasks that should process over this array.</param>
            /// <returns>Loops over each item in the specified array.</returns>
            public static FuncResult<U> ForEach<T1, T2, U>(T1[] Items, T2 Argument1, Func<T1, T2, U> action, Int32 TaskCount) {
                if (TaskCount < 1) {
                    throw new ArgumentOutOfRangeException(nameof(TaskCount));
                }

                var Tasks = new Task[TaskCount];
                Int32 Length = Items.Length;
                var Receiver = new U[Length];

                Int32 Step = Length / TaskCount;
                Int32 Max = TaskCount - 1;

                //Creates sections and start
                for (Int32 I = 0; I < Max; I++) {
                    //Creates the context for this section
                    var Context = new ParallelFuncContext<T1, T2, U>() {
                        _StartIndex = I * Step,
                        _EndIndex = (I + 1) * Step,
                        _Items = Items,
                        _Action = action,
                        _Argument1 = Argument1,
                        _Receiver = Receiver
                    };

                    Tasks[I] = Task.Factory.StartNew(Context.Invoke);
                }

                //Creates the last
                Int32 Start = Max * Step;
                var Context1 = new ParallelFuncContext<T1, T2, U>() {
                    _StartIndex = Start,
                    _EndIndex = Items.Length,
                    _Items = Items,
                    _Action = action,
                    _Argument1 = Argument1,
                    _Receiver = Receiver
                };

                Tasks[Max] = Task.Factory.StartNew(Context1.Invoke);

                return new FuncResult<U>(Tasks, Receiver);
            }
        }
    }
}
