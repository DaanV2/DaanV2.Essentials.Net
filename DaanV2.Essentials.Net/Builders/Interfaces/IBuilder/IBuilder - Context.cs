/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

namespace DaanV2.Builders {
    /// <summary>The interface that responsible for building a specified class with/without context.</summary>
    /// <typeparam name="TypeToBuild">The type to build to.</typeparam>
    /// <typeparam name="TIn">The object type in.</typeparam>
    /// <typeparam name="ContextType">The context type.</typeparam>
    public interface IBuilderContext<TypeToBuild, TIn, ContextType> :
        IBuilder<TypeToBuild, TIn>,
        IBuilderAddContext<TIn, ContextType> {
    }
}