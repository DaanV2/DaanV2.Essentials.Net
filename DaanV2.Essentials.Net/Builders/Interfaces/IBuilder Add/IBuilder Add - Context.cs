/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

namespace DaanV2.Builders {
    /// <summary>A subpart of a <see cref="IBuilder{TypeToBuild, TIn}"/> that specifies if a different object can be added with context.</summary>
    public interface IBuilderAddContext<TypeToAdd, ContextType> {
        /// <summary>Adds the specific object to the build.</summary>
        /// <param name="O">The object to check if it can be added.</param>
        /// <param name="Context">The relevant context needed to possibly help identify the object.</param>
        void Add(TypeToAdd O, ContextType Context);
    }
}
