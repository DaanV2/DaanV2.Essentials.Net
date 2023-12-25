using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace DaanV2.Binary {
    public static partial class BitConverter {
        public static partial class BigEndian {
            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>            
            public static void OntoBytes([NotNull] Byte[] Receiver, Int16 Value, Int32 StartIndex = 0) {
                OntoBytes(Receiver, (UInt16)Value, StartIndex);
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Span">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            public static void OntoBytes(Span<Byte> Span, Int16 Value) {
                OntoBytes(Span, (UInt16)Value);
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            public static void OntoBytes([NotNull] Byte[] Receiver, Int32 Value, Int32 StartIndex = 0) {
                OntoBytes(Receiver, (UInt32)Value, StartIndex);
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Span">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            public static void OntoBytes(Span<Byte> Span, Int32 Value) {
                OntoBytes(Span, (UInt32)Value);
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            public static void OntoBytes(Byte[] Receiver, Int64 Value, Int32 StartIndex = 0) {
                OntoBytes(Receiver, (UInt64)Value, StartIndex);
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Span">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            public static void OntoBytes(Span<Byte> Span, Int64 Value) {
                OntoBytes(Span, (UInt64)Value);
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            public static void OntoBytes([NotNull] Byte[] Receiver, UInt16 Value, Int32 StartIndex = 0) {
                Span<Byte> Slice = Receiver.AsSpan(StartIndex, sizeof(UInt16));

                OntoBytes(Slice, Value);
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Span">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void OntoBytes(Span<Byte> Span, UInt16 Value) {
                Span[1] = (Byte)Value;
                Value >>= 8;
                Span[0] = (Byte)Value;
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            public static void OntoBytes([NotNull] Byte[] Receiver, UInt32 Value, Int32 StartIndex = 0) {
                Span<Byte> Slice = Receiver.AsSpan(StartIndex, sizeof(UInt32));

                OntoBytes(Slice, Value);
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Span">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void OntoBytes(Span<Byte> Span, UInt32 Value) {
                Span[3] = (Byte)Value;
                Value >>= 8;
                Span[2] = (Byte)Value;
                Value >>= 8;
                Span[1] = (Byte)Value;
                Value >>= 8;
                Span[0] = (Byte)Value;
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            public static void OntoBytes(Byte[] Receiver, UInt64 Value, Int32 StartIndex = 0) {
                Span<Byte> Slice = Receiver.AsSpan(StartIndex, sizeof(UInt64));

                OntoBytes(Slice, Value);
            }

            /// <summary>Converts the given object into a <see cref="Byte"/> array</summary>
            /// <param name="Span">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the given object into a <see cref="Byte"/> array</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void OntoBytes(Span<Byte> Span, UInt64 Value) {
                Span[7] = (Byte)Value;
                Value >>= 8;
                Span[6] = (Byte)Value;
                Value >>= 8;
                Span[5] = (Byte)Value;
                Value >>= 8;
                Span[4] = (Byte)Value;
                Value >>= 8;
                Span[3] = (Byte)Value;
                Value >>= 8;
                Span[2] = (Byte)Value;
                Value >>= 8;
                Span[1] = (Byte)Value;
                Value >>= 8;
                Span[0] = (Byte)Value;
            }
        }
    }
}