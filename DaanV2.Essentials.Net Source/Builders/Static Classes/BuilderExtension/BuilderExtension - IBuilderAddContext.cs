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
        /// <param name="Builder"></param>
        /// <param name="Items"></param>
        public static void Add<T>(this IBuilderAdd<T> Builder, T[] Items) {
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
        public static void Add<T>(this IBuilderAdd<T> Builder, List<T> Items) {
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
        public static void Add<T>(this IBuilderAdd<T> Builder, IEnumerable<T> Items) {
            foreach (T Item in Items) {
                Builder.Add(Item);
            }
        }
    }
}
