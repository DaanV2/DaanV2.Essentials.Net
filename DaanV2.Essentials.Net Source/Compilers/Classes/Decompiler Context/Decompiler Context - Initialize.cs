/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Runtime.Serialization;

namespace DaanV2.Compilers {
    ///<summary>The class responsible for giving the necessary information to decompile a file/folder.</summary>
	[Serializable, DataContract]
    public partial class DecompilerContext : IDecompilerContext {

        /// <summary>Creates a new instance of <see cref="DecompilerContext"/>.</summary>
        /// <param name="InputPath">The input path that points to a folder/file.</param>
        /// <param name="PathInputType">The type of path being inputted.</param>
        public DecompilerContext(String InputPath = "", PathType PathInputType = PathType.File) {
            this._Path = InputPath;
            this._PathType = PathInputType;
        }
    }
}
