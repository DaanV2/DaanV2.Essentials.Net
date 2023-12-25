using System;

namespace DaanV2.Compilers {
    /// <summary>The interface responsible for forming the contract on how the Decompilers context should work.</summary>
    public interface IDecompilerContext {

        /// <summary>Get or sets the filepath/folderpath.</summary>
        String Path { get; set; }

        /// <summary>Gets or sets the path type.</summary>
        PathType PathType { get; set; }
    }
}