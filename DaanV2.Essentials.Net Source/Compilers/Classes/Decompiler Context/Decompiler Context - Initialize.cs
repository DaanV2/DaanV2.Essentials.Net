/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.


THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS.IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;
using System.Runtime.Serialization;

namespace DaanV2.Compilers {
    ///<summary>The class responsible for giving the necessary information to decompile a file/folder</summary>
	[Serializable, DataContract]
    public partial class DecompilerContext : IDecompilerContext {

        /// <summary>Creates a new instance of <see cref="DecompilerContext"/></summary>
        /// <param name="InputPath">The input path that points to a folder/file</param>
        /// <param name="PathInputType">The type of path being inputted</param>
        public DecompilerContext(String InputPath = "", PathType PathInputType = PathType.File) {
            this._Path = InputPath;
            this._PathType = PathInputType;
        }
    }
}
