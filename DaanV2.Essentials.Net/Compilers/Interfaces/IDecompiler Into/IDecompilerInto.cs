/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
namespace DaanV2.Compilers {

    /// <summary>The interface that responsible for how a decompiler should work.</summary>
    /// <typeparam name="TReceiver">The object type that can receive the output.</typeparam>
    /// <typeparam name="ContextType">The context type used to tell what to decompile.</typeparam>
    public interface IDecompilerInto<TReceiver, ContextType> {
        
        /// <summary>Decompile the specified files into the receiver.</summary>
        /// <param name="Context">The context used to tell what to decompile.</param>
        /// <param name="Receiver">The object to receiver the output.</param>
        void DecompileInto(ContextType Context, TReceiver Receiver);
    }
}
