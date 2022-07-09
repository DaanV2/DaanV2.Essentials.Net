/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Collections.Generic;

namespace DaanV2.Processors {
    public static partial class ProcessorExtension {
        /// <summary>Puts a collection of given items through the postprocessor.</summary>
        /// <typeparam name="T">The type of object to process.</typeparam>
        /// <param name="Processor">The processor to use.</param>
        /// <param name="Items">The items to process.</param>
        /// <returns>Puts a collection of given items through the processor.</returns>
        public static void Postprocess<T>(this IPostProcessor<T> Processor, T[] Items) {
            Int32 Count = Items.Length;

            for (Int32 I = 0; I < Count; I++) {
                Processor.Postprocess(Items[I]);
            }
        }

        /// <summary>Puts a collection of given items through the postprocessor.</summary>
        /// <typeparam name="T">The type of object to process.</typeparam>
        /// <param name="Processor">The processor to use.</param>
        /// <param name="Items">The items to process.</param>
        /// <returns>Puts a collection of given items through the processor.</returns>
        public static void Postprocess<T>(this IPostProcessor<T> Processor, IList<T> Items) {
            Int32 Count = Items.Count;

            for (Int32 I = 0; I < Count; I++) {
                Processor.Postprocess(Items[I]);
            }
        }

        /// <summary>Puts a collection of given items through the postprocessor.</summary>
        /// <typeparam name="T">The type of object to process.</typeparam>
        /// <param name="Processor">The processor to use.</param>
        /// <param name="Items">The items to process.</param>
        /// <returns>Puts a collection of given items through the processor.</returns>
        public static void Postprocess<T>(this IPostProcessor<T> Processor, IEnumerable<T> Items) {
            foreach (T Item in Items) {
                Processor.Postprocess(Item);
            }
        }
    }
}