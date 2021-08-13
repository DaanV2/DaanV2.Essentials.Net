/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

using System;
using System.Collections.Generic;

namespace DaanV2.Builders {
    ///DOLATER <summary>add description for class: BuilderExtension</summary>
    public static partial class BuilderExtension {
        /// <summary>Adds the given collection to the builder</summary>
        /// <typeparam name="T">The items to add</typeparam>
        /// <typeparam name="CT">The context needed to add these items</typeparam>
        /// <param name="Builder">The builder to receive the items</param>
        /// <param name="Items">The items to add</param>
        /// <param name="Context">The context needed to add the items</param>
        public static void Add<T, CT>(this IBuilderAddContext<T, CT> Builder, T[] Items, CT Context) {
            Int32 Count = Items.Length;

            for (Int32 I = 0; I < Count; I++) {
                Builder.Add(Items[I], Context);
            }
        }

        /// <summary>Adds the given collection to the builder</summary>
        /// <typeparam name="T">The items to add</typeparam>
        /// <typeparam name="CT">The context needed to add these items</typeparam>
        /// <param name="Builder">The builder to receive the items</param>
        /// <param name="Items">The items to add</param>
        /// <param name="Context">The context needed to add the items</param>
        public static void Add<T, CT>(this IBuilderAddContext<T, CT> Builder, List<T> Items, CT Context) {
            Int32 Count = Items.Count;

            for (Int32 I = 0; I < Count; I++) {
                Builder.Add(Items[I], Context);
            }
        }

        /// <summary>Adds the given collection to the builder</summary>
        /// <typeparam name="T">The items to add</typeparam>
        /// <typeparam name="CT">The context needed to add these items</typeparam>
        /// <param name="Builder">The builder to receive the items</param>
        /// <param name="Items">The items to add</param>
        /// <param name="Context">The context needed to add the items</param>
        public static void Add<T, CT>(this IBuilderAddContext<T, CT> Builder, IEnumerable<T> Items, CT Context) {
            foreach (T Item in Items) {
                Builder.Add(Item, Context);
            }
        }
    }
}
