namespace DaanV2.Compilers {

    ///DOLATER <summary> add description for interface: IDecompilerInto</summary>
    public interface IDecompilerInto<TReceiver, ContextType> {
        ///DOLATER <summary>Add Description</summary>
        /// <param name="">FILL_ME_IN</param>
        /// <param name="Receiver">FILL_ME_IN</param>
        void DecompileInto(ContextType Context, TReceiver Receiver);
    }
}
