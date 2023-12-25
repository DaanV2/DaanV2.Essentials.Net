
namespace DaanV2.Compilers {
    /// <summary>The interface that is responsible for forming the contract on how compilers should transfer data between files and object with given context.</summary>
    public interface ICompiler<TypeFrom, TypeContext> {

        /// <summary>Compiles the given object and context.</summary>
        /// <param name="Process">The object to compile.</param>
        /// <param name="Context">The context needed to compile the object.</param>
        void Compile(ICompilerContext<TypeFrom> Process, TypeContext Context);
    }
}