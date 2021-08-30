using System;
using System.Buffers;
using System.IO;

namespace DaanV2.IO {
    ///DOLATER <summary>add description for abstract class: BufferedStream</summary>
    public abstract partial class BufferedStream : Stream {
        private const Int32 BufferSize = sizeof(UInt16) + sizeof(Int16) + sizeof(UInt32) + sizeof(Int32) + sizeof(UInt64) + sizeof(Int64);
        private readonly Byte[] _Buffer;


        /// <summary>
        /// 
        /// </summary>
        protected BufferedStream() : base() {
            this._Buffer = ArrayPool<Byte>.Shared.Rent(BufferSize);
        }

        /// <summary>
        /// 
        /// </summary>
        ~BufferedStream() {
            ArrayPool<Byte>.Shared.Return(this._Buffer, false);
        }

    }
}
