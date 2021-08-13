/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

namespace DaanV2.Compilers {
    /// <summary>The interfaceresponsible for forming the contract on how compiler context should be used.</summary>
    public interface ICompilerContext<ProcessObjectType> : IDecompilerContext {

        /// <summary>Gets or sets the object to process.</summary>
        ProcessObjectType ObjectToProcess { get; set; }
    }
}
