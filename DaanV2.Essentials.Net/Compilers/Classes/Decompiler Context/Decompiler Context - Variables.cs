/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

using System;

namespace DaanV2.Compilers {
    public partial class DecompilerContext {

        /// <summary>Gets or sets the filepath/folder to the place that needs to be decompiled of this <see cref="DecompilerContext"/>.</summary>
        private protected String _Path;

        /// <summary>Gets or sets the path type of this <see cref="DecompilerContext"/>.</summary>
        private protected PathType _PathType;

    }
}