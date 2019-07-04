﻿/*ISC License

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
using System.Threading.Tasks;

namespace DaanV2 {
    public static partial class TaskExtension {

        /// <summary>Waits for all tasks to finish</summary>
        /// <param name="Tasks">The array of tasks to wait for</param>
		public static void WaitAll(this Task[] Tasks) {
            Task.WaitAll(Tasks);
        }

        /// <summary>Waits for any of the tasks to finish</summary>
        /// <param name="Tasks">The array of tasks to wait for</param>
        public static void WaitAny(this Task[] Tasks) {
            Task.WaitAny(Tasks);
        }
    }
}
