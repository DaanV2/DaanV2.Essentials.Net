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

namespace DaanV2.Processors {
    public static partial class ProcessorExtension {
        /// <summary>Puts a collection of given items through the preprocessor</summary>
        /// <typeparam name="T">The type of object to process</typeparam>
        /// <param name="Processor">The processor to use</param>
        /// <param name="Items">The items to process</param>
        /// <returns>Puts a collection of given items through the processor</returns>
        public static void Preprocess<T>(this IPreProcessor<T> Processor, T[] Items) {
            Int32 Count = Items.Length;

            for (Int32 I = 0; I < Count; I++) {
                Processor.Preprocess(Items[I]);
            }
        }

        /// <summary>Puts a collection of given items through the preprocessor</summary>
        /// <typeparam name="T">The type of object to process</typeparam>
        /// <param name="Processor">The processor to use</param>
        /// <param name="Items">The items to process</param>
        /// <returns>Puts a collection of given items through the processor</returns>
        public static void Preprocess<T>(this IPreProcessor<T> Processor, IList<T> Items) {
            Int32 Count = Items.Count;

            for (Int32 I = 0; I < Count; I++) {
                Processor.Preprocess(Items[I]);
            }
        }

        /// <summary>Puts a collection of given items through the preprocessor</summary>
        /// <typeparam name="T">The type of object to process</typeparam>
        /// <param name="Processor">The processor to use</param>
        /// <param name="Items">The items to process</param>
        /// <returns>Puts a collection of given items through the processor</returns>
        public static void Preprocess<T>(this IPreProcessor<T> Processor, IEnumerable<T> Items) {
            foreach (T Item in Items) {
                Processor.Preprocess(Item);
            }
        }
    }
}
