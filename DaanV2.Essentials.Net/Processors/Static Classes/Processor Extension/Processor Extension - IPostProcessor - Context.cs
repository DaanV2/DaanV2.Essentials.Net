using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DaanV2.Processors {
    public static partial class ProcessorExtension {
        /// <summary>Puts a collection of given items through the postprocessor.</summary>
        /// <typeparam name="T">The type of object to process.</typeparam>
        /// <typeparam name="TContext">The type of the context.</typeparam>
        /// <param name="Processor">The processor to use.</param>
        /// <param name="Items">The items to process.</param>
        /// <param name="Context">The context needed to process.</param>
        public static void Postprocess<T, TContext>([NotNull] this IPostProcessor<T, TContext> Processor, [NotNull] T[] Items, TContext Context) {
            Int32 Count = Items.Length;

            for (Int32 I = 0; I < Count; I++) {
                Processor.Postprocess(Items[I], Context);
            }
        }

        /// <summary>Puts a collection of given items through the postprocessor.</summary>
        /// <typeparam name="T">The type of object to process.</typeparam>
        /// <typeparam name="TContext">The type of the context.</typeparam>
        /// <param name="Processor">The processor to use.</param>
        /// <param name="Items">The items to process.</param>
        /// <param name="Context">The context needed to process.</param>
        public static void Postprocess<T, TContext>([NotNull] this IPostProcessor<T, TContext> Processor, [NotNull] IList<T> Items, TContext Context) {
            Int32 Count = Items.Count;

            for (Int32 I = 0; I < Count; I++) {
                Processor.Postprocess(Items[I], Context);
            }
        }

        /// <summary>Puts a collection of given items through the postprocessor.</summary>
        /// <typeparam name="T">The type of object to process.</typeparam>
        /// <typeparam name="TContext">The type of the context.</typeparam>
        /// <param name="Processor">The processor to use.</param>
        /// <param name="Items">The items to process.</param>
        /// <param name="Context">The context needed to process.</param>
        public static void Postprocess<T, TContext>([NotNull] this IPostProcessor<T, TContext> Processor, [NotNull] IEnumerable<T> Items, TContext Context) {
            foreach (T Item in Items) {
                Processor.Postprocess(Item, Context);
            }
        }
    }
}