namespace DaanV2.Builders {
    /// <summary>A subpart of a <see cref="IBuilder{TypeToBuild, TIn}"/> that specifies if a different object can be added.</summary>
    public interface IBuilderAdd<TypeToAdd> {
        /// <summary>Adds the specific object to the build.</summary>
        /// <param name="O">The object to check if it can be added.</param>
        void Add(TypeToAdd O);
    }
}