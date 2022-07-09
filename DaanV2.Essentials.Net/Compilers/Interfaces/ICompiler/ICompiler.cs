/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

namespace DaanV2.Compilers {
    /// <summary>The interface that is responsible for forming the contract on how compilers should transfer data between files and object.</summary>
    /// <typeparam name="TypeProcess">The type to be compiled.</typeparam>
    public interface ICompiler<TypeProcess> {
        /// <summary>Compiles the given context.</summary>
        /// <param name="Process">The information that is needed to compile.</param>
        void Compile(ICompilerContext<TypeProcess> Process);
    }
}