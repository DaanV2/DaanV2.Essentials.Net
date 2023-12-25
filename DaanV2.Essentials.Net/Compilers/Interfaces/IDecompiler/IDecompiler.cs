
namespace DaanV2.Compilers {
    /// <summary>The interface responsible for forming the contract on how Decompilers should work.</summary>
    /// <typeparam name="TypeTo">The type that needs to be returned.</typeparam>
    public interface IDecompiler<TypeTo> : IDecompiler<TypeTo, IDecompilerContext> {
    }
}