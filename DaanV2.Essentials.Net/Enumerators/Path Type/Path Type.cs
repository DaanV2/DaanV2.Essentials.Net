using System;
using System.Runtime.Serialization;

namespace DaanV2 {
    /// <summary>A enumerator that helps indentifing what kind of path has been filled in.</summary>
	[Serializable, DataContract]
    public enum PathType : Byte {
        ///<summary>Marks that the given path belongs to a file.</summary>
        File,
        /// <summary>Marks that the given path is a folder.</summary>
        Folder
    }
}