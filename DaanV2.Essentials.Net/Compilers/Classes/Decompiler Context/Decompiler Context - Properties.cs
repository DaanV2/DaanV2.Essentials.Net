/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

using System;

namespace DaanV2.Compilers {
    public partial class DecompilerContext {

        /// <summary>Gets or sets the filepath/folder to the place that needs to be decompiled of this <see cref="DecompilerContext"/>.</summary>
        public String Path {
            get => this._Path;
            set => this._Path = value;
        }

        /// <summary>Gets or sets the path type of this <see cref="DecompilerContext"/>.</summary>
        public PathType PathType {
            get => this._PathType;
            set => this._PathType = value;
        }
    }
}