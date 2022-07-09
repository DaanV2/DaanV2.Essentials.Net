﻿/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
namespace DaanV2.Compilers {
    public partial class CompilerContext<TypeIn> {
        /// <summary>The object to compile.</summary>
        public TypeIn ObjectToProcess {
            get => this._ObjectToProcess;
            set => this._ObjectToProcess = value;
        }
    }
}