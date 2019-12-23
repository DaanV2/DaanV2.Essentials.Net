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
using System.Threading.Tasks;

namespace DaanV2 {
    /// <summary>The class that creates parralel tasks</summary>
    public static partial class Parralel {
        /// <summary>Loops over each item in the specified array</summary>
        /// <typeparam name="T">The type inside the array</typeparam>
        /// <param name="Items"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static Task[] ForEach<T>(T[] Items, Action<T> action) {
            Task[] Out = new Task[Environment.ProcessorCount];

            Int32 Step = Items.Length / Out.Length;
            Int32 Max = Out.Length - 1;
            Action<Object> InternalAction = (x) => {
                Parralel.ForEachInternal((ParralelContext<T>)x);
            };

            for (Int32 I = 0; I < Max; I++) {
                ParralelContext<T> Context = new ParralelContext<T>(I * Step, (I + 1) * Step, Items, action);
                Out[I] = Task.Factory.StartNew(InternalAction, Context);
            }

            ParralelContext<T> Context1 = new ParralelContext<T>(Max * Step, Items.Length, Items, action);
            Out[Max] = Task.Factory.StartNew(InternalAction, Context1);

            return Out;
        }

        /// <summary>Loops over each item in the specified array</summary>
        /// <typeparam name="T">The type inside the array</typeparam>
        /// <param name="Items"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static Task[] ForEach<T>(ICollection<T> Items, Action<T> action) {
            Task[] Out = new Task[Environment.ProcessorCount];

            Int32 Step = Items.Count / Out.Length;
            Int32 Max = Out.Length - 1;
            Action<Object> InternalAction = (x) => {
                Parralel.ForEachInternal((ParralelContext<T>)x);
            };

            for (Int32 I = 0; I < Max; I++) {
                ParralelContextCollection<T> Context = new ParralelContextCollection<T>(I * Step, (I + 1) * Step, Items, action);
                Out[I] = Task.Factory.StartNew(InternalAction, Context);
            }

            ParralelContextCollection<T> Context1 = new ParralelContextCollection<T>(Max * Step, Items.Count, Items, action);
            Out[Max] = Task.Factory.StartNew(InternalAction, Context1);

            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Items"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static Task[] ForEach<T, T1>(T[] Items, Action<T, T1> action, T1 Argument) {
            Task[] Out = new Task[Environment.ProcessorCount];

            Int32 Step = Items.Length / Out.Length;
            Int32 Max = Out.Length - 1;
            Action<Object> InternalAction = (x) => {
                Parralel.ForEachInternal((ParralelContext<T, T1>)x);
            };

            for (Int32 I = 0; I < Max; I++) {
                ParralelContext<T, T1> Context = new ParralelContext<T, T1>(I * Step, (I + 1) * Step, Items, action, Argument);
                Out[I] = Task.Factory.StartNew(InternalAction, Context);
            }

            ParralelContext<T, T1> Context1 = new ParralelContext<T, T1>(Max * Step, Items.Length, Items, action, Argument);
            Out[Max] = Task.Factory.StartNew(InternalAction, Context1);

            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Items"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static Task[] ForEach<T, T1>(ICollection<T> Items, Action<T, T1> action, T1 Argument) {
            Task[] Out = new Task[Environment.ProcessorCount];

            Int32 Step = Items.Count / Out.Length;
            Int32 Max = Out.Length - 1;
            Action<Object> InternalAction = (x) => {
                Parralel.ForEachInternal((ParralelContext<T, T1>)x);
            };

            for (Int32 I = 0; I < Max; I++) {
                ParralelContextCollection<T, T1> Context = new ParralelContextCollection<T, T1>(I * Step, (I + 1) * Step, Items, action, Argument);
                Out[I] = Task.Factory.StartNew(InternalAction, Context);
            }

            ParralelContextCollection<T, T1> Context1 = new ParralelContextCollection<T, T1>(Max * Step, Items.Count, Items, action, Argument);
            Out[Max] = Task.Factory.StartNew(InternalAction, Context1);

            return Out;
        }
    }
}
