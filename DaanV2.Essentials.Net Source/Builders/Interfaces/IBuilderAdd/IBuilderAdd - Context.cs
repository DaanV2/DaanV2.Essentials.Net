namespace DaanV2.Builders {
    ///DOLATER <summary> add description for interface: IBuilderAdd</summary>
    public interface IBuilderAddContext<TypeToAdd, ContextType> {
        /// <summary>Adds the specific object to the build</summary
        /// <param name="O">The object to check if it can be added</param>
        /// <param name="Context">The relevant context needed to possibly help identify the object</param>
        void Add(TypeToAdd O, ContextType Context);
    }
}
