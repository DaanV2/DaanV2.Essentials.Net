/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

namespace DaanV2.Builders {
    /// <summary>The interface that is responsible for forming the contract between builders and output types.</summary>
    /// <typeparam name="TypeToBuild">The output type that will be build.</typeparam>
    /// <typeparam name="TIn">The type that can be added into the build.</typeparam>
    public interface IBuilder<TypeToBuild, TIn> : IBuilderAdd<TIn> {
        /// <summary>Set the base object of this builder to work on.</summary>
        /// <param name="Base">The base object.</param>
        void SetBase(TypeToBuild Base);

        /// <summary>Returns the builded version of the specified.</summary>
        /// <returns>Returns the builded version of the specified.</returns>
        TypeToBuild BuildFinal();
    }
}