using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DaanV2.IO {
    ///<summary>A file sorter that sorts file that all come from the same directory</summary>
    public readonly partial struct FileSorter {
        private readonly Int32 _Skip;

        /// <summary>Creates a new instance of <see cref="FileSorter"/></summary>
        /// <param name="Skip">The amount of character to skip at the start of the path</param>
        public FileSorter(Int32 Skip) {
            this._Skip = Skip;
        }

        /// <summary>Creates a new instance of <see cref="FileSorter"/></summary>
        /// <param name="BaseFolder">The basefolder all files path have</param>
        public FileSorter(String BaseFolder) : this(BaseFolder.Length) { }

        /// <summary>Compare the two given files, assuming they both share the same basefolder</summary>
        /// <param name="FilepathA">The first path to sort</param>
        /// <param name="FilepathB">The second path to sort</param>
        /// <returns>A signed integer that indicates the relative order of span and other: - If less
        ///     than 0, span precedes than other. - If 0, span equals other. - If greater than
        ///     0, span follows other.</returns>
        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public Int32 Compare(String FilepathA, String FilepathB) {
            ReadOnlySpan<Char> SpanA = FilepathA.AsSpan(this._Skip);
            ReadOnlySpan<Char> SpanB = FilepathB.AsSpan(this._Skip);

            return SpanA.CompareTo(SpanB, StringComparison.Ordinal);
        }

        /// <summary>Sorts the given files</summary>
        /// <param name="Files">The files to sort</param>
        /// <param name="BaseFolder">The shared base folder of all files</param>
        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public static void Sort(String[] Files, String BaseFolder) {
            var Sorter = new FileSorter(BaseFolder);
            Array.Sort(Files, Sorter.Compare);
        }

        /// <summary>Sorts the given files</summary>
        /// <param name="Files">The files to sort</param>
        /// <param name="BaseFolder">The shared base folder of all files</param>
        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public static void Sort(List<String> Files, String BaseFolder) {
            var Sorter = new FileSorter(BaseFolder);
            Files.Sort(Sorter.Compare);
        }
    }
}