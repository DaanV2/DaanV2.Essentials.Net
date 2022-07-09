/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;

namespace DaanV2.Binary {

    public static partial class BitConverter {
        public static partial class Varint {
            /// <summary>Converts the given value into a <see cref="Byte"/> array</summary>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the given value into a <see cref="Byte"/> array</returns>
            public static Byte[] ToBytes(Int32 Value) {
                Int32 Count = Varint.ByteCount((UInt32)Value);
                Int32 Mark = Count - 1;

                Byte[] Out = new Byte[Count];

                for (Int32 I = 0; I < Mark; I++) {
                    Out[I] = (Byte)(Value | Varint._SignalMask);

                    Value >>= 7;
                }

                Out[Mark] = (Byte)(Value & Varint._NonSignalMask);

                return Out;
            }

            /// <summary>Converts the given value into a <see cref="Byte"/> array</summary>
            /// <param name="Value">The object to convert</param>
            /// <returns>Converts the given value into a <see cref="Byte"/> array</returns>
            public static Byte[] ToBytes(Int64 Value) {
                Int32 Count = Varint.ByteCount((UInt64)Value);
                Int32 Mark = Count - 1;

                Byte[] Out = new Byte[Count];

                for (Int32 I = 0; I < Mark; I++) {
                    Out[I] = (Byte)(Value | Varint._SignalMask);

                    Value >>= 7;
                }

                Out[Mark] = (Byte)(Value & Varint._NonSignalMask);

                return Out;
            }

            /// <summary>Converts the given value into a <see cref="Byte"/> array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given value into a <see cref="Byte"/> array</returns>
            public static Int32 OntoBytes(Byte[] Receiver, Int32 Value, Int32 StartIndex = 0) {
                if (Receiver is null) {
                    throw new ArgumentNullException(nameof(Receiver));
                }

                Int32 Count = Varint.ByteCount((UInt32)Value);
                Int32 Mark = Count - 1 + StartIndex;

                if (Mark >= Receiver.Length) {
                    throw new ArgumentException($"Receiving byte array is not of an proper length");
                }

                for (Int32 I = StartIndex; I < Mark; I++) {
                    Receiver[I] = (Byte)(Value | Varint._SignalMask);

                    Value >>= 7;
                }

                Receiver[Mark] = (Byte)(Value & Varint._NonSignalMask);
                return Count;
            }

            /// <summary>Converts the given value into a <see cref="Byte"/> array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given value into a <see cref="Byte"/> array</returns>
            public static Int32 OntoBytes(Byte[] Receiver, Int64 Value, Int32 StartIndex = 0) {
                if (Receiver is null) {
                    throw new ArgumentNullException(nameof(Receiver));
                }

                Int32 Count = Varint.ByteCount((UInt32)Value);
                Int32 Mark = Count - 1 + StartIndex;

                if (Mark >= Receiver.Length) {
                    throw new ArgumentException($"Receiving byte array is not of an proper length");
                }

                for (Int32 I = StartIndex; I < Mark; I++) {
                    Receiver[I] = (Byte)((Byte)(Value & Varint._NonSignalMask) | Varint._SignalMask);

                    Value >>= 7;
                }

                Receiver[Mark] = (Byte)(Value & Varint._NonSignalMask);
                return Count;
            }
        }
    }
}