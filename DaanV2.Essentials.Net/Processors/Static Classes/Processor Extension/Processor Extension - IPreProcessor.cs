using System;
using System.Collections.Generic;

namespace DaanV2.Processors {
    public static partial class ProcessorExtension {
        /// <summary>Puts a collection of given items through the preprocessor.</summary>
        /// <typeparam name="T">The type of object to process.</typeparam>
        /// <param name="Processor">The processor to use.</param>
        /// <param name="Items">The items to process.</param>
        /// <returns>Puts a collection of given items through the processor.</returns>
        public static void Preprocess<T>(this IPreProcessor<T> Processor, T[] Items) {
            Int32 Count = Items.Length;

            for (Int32 I = 0; I < Count; I++) {
                Processor.Preprocess(Items[I]);
            }
        }

        /// <summary>Puts a collection of given items through the preprocessor.</summary>
        /// <typeparam name="T">The type of object to process.</typeparam>
        /// <param name="Processor">The processor to use.</param>
        /// <param name="Items">The items to process.</param>
        /// <returns>Puts a collection of given items through the processor.</returns>
        public static void Preprocess<T>(this IPreProcessor<T> Processor, IList<T> Items) {
            Int32 Count = Items.Count;

            for (Int32 I = 0; I < Count; I++) {
                Processor.Preprocess(Items[I]);
            }
        }

        /// <summary>Puts a collection of given items through the preprocessor.</summary>
        /// <typeparam name="T">The type of object to process.</typeparam>
        /// <param name="Processor">The processor to use.</param>
        /// <param name="Items">The items to process.</param>
        /// <returns>Puts a collection of given items through the processor.</returns>
        public static void Preprocess<T>(this IPreProcessor<T> Processor, IEnumerable<T> Items) {
            foreach (T Item in Items) {
                Processor.Preprocess(Item);
            }
        }
    }
}