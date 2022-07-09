/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Runtime.Serialization;
using DaanV2;

namespace DaanV2.Compilers {
    /// <summary>A base object containing the basic information needed for a compiling process.</summary>
    /// <typeparam name="TypeIn">The object type to compile.</typeparam>
	[Serializable, DataContract]
    public partial class CompilerContext<TypeIn> : DecompilerContext, ICompilerContext<TypeIn> {

        /// <summary>Creates a new instance of <see cref="CompilerContext{TypeIn}"/>.</summary>
        /// <param name="ToCompile">The object to compile.</param>
        /// <param name="OutputPath">The output filepath/folder.</param>
        /// <param name="OutputType">Specifies what kind of path has been given.</param>
        public CompilerContext(TypeIn ToCompile, String OutputPath = "", PathType OutputType = PathType.File) :
            base(OutputPath, OutputType) {
            this.ObjectToProcess = ToCompile;
        }
    }
}