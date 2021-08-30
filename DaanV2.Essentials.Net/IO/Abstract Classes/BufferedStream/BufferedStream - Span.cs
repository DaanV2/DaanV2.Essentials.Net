using System;
using System.Runtime.CompilerServices;

namespace DaanV2.IO {
    ///DOLATER <summary>add description for abstract class: BufferedStream</summary>
    public abstract partial class BufferedStream {
        /// <summary></summary>
        protected const Int32 UInt16_Index = 0;

        /// <summary></summary>
        protected const Int32 Int16_Index = UInt16_Index + sizeof(UInt16);

        /// <summary></summary>
        protected const Int32 UInt32_Index = Int16_Index + sizeof(Int16);

        /// <summary></summary>
        protected const Int32 Int32_Index = UInt32_Index + sizeof(UInt32);

        /// <summary></summary>
        protected const Int32 UInt64_Index = Int32_Index + sizeof(Int32);

        /// <summary></summary>
        protected const Int32 Int64_Index = UInt64_Index + sizeof(UInt64);

        /// <summary></summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected Span<Byte> UInt16Buffer() {
            return this._Buffer.AsSpan(UInt16_Index, sizeof(UInt16));
        }

        /// <summary></summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected Span<Byte> Int16Buffer() {
            return this._Buffer.AsSpan(Int16_Index, sizeof(Int16));
        }

        /// <summary></summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected Span<Byte> UInt32Buffer() {
            return this._Buffer.AsSpan(UInt32_Index, sizeof(UInt32));
        }

        /// <summary></summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected Span<Byte> Int32Buffer() {
            return this._Buffer.AsSpan(Int32_Index, sizeof(Int32));
        }

        /// <summary></summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected Span<Byte> UInt64Buffer() {
            return this._Buffer.AsSpan(UInt64_Index, sizeof(UInt64));
        }

        /// <summary></summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected Span<Byte> Int64Buffer() {
            return this._Buffer.AsSpan(Int64_Index, sizeof(Int64));
        }

        /// <summary></summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected Span<Byte> Buffer() { 
            return this._Buffer.AsSpan();
        }
    }
}