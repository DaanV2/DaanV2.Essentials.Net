/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

namespace DaanV2.Compilers {
    /// <summary>The interface responsible for forming the contract on how Decompilers should work.</summary>
    /// <typeparam name="TypeTo">The type that needs to be returned.</typeparam>
    /// <typeparam name="TypeContext">The type that is used as context for processing.</typeparam>
    public interface IDecompiler<TypeTo, TypeContext> {

        /// <summary>Decompiles the given context into the specified object.</summary>
        /// <param name="Context">The context that specifies where the information can be found.</param>
        /// <returns>Decompiles the given context into the specified object.</returns>
        TypeTo Decompile(TypeContext Context);
    }
}