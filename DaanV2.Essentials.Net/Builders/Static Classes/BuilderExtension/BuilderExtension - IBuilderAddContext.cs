
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DaanV2.Builders {
    ///DOLATER <summary>add description for class: BuilderExtension</summary>
    public static partial class BuilderExtension {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Builder"></param>
        /// <param name="Items"></param>
        public static void Add<T>([NotNull] this IBuilderAdd<T> Builder, [NotNull] T[] Items) {
            Int32 Count = Items.Length;

            for (Int32 I = 0; I < Count; I++) {
                Builder.Add(Items[I]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Builder"></param>
        /// <param name="Items"></param>
        public static void Add<T>([NotNull] this IBuilderAdd<T> Builder, [NotNull] List<T> Items) {
            Int32 Count = Items.Count;

            for (Int32 I = 0; I < Count; I++) {
                Builder.Add(Items[I]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Builder"></param>
        /// <param name="Items"></param>
        public static void Add<T>([NotNull] this IBuilderAdd<T> Builder, [NotNull] IEnumerable<T> Items) {
            foreach (T Item in Items) {
                Builder.Add(Item);
            }
        }
    }
}