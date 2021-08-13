/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

using System;
using System.Collections.Generic;

namespace DaanV2.Builders {
    ///DOLATER <summary>add description for class: BuilderExtension</summary>
    public static partial class BuilderExtension {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="CT"></typeparam>
        /// <param name="Builder"></param>
        /// <param name="Items"></param>
        /// <param name="Context"></param>
        public static void Add<T, CT>(this IBuilderAddContext<T, CT> Builder, T[] Items, CT Context) {
            Int32 Count = Items.Length;

            for (Int32 I = 0; I < Count; I++) {
                Builder.Add(Items[I], Context);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Builder"></param>
        /// <param name="Items"></param>
        public static void Add<T, CT>(this IBuilderAddContext<T, CT> Builder, List<T> Items, CT Context) {
            Int32 Count = Items.Count;

            for (Int32 I = 0; I < Count; I++) {
                Builder.Add(Items[I], Context);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Builder"></param>
        /// <param name="Items"></param>
        public static void Add<T, CT>(this IBuilderAddContext<T, CT> Builder, IEnumerable<T> Items, CT Context) {
            foreach (T Item in Items) {
                Builder.Add(Item, Context);
            }
        }
    }
}
