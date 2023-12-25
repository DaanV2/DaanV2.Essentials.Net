using System;

namespace DaanV2.Binary {

    public static partial class BitConverter {
        public static partial class VarInt {
            /// <summary>Converts the given byte array into an <see cref="Int32"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given byte array into an <see cref="Int32"/></returns>
            public static Int32 ToInt32(Byte[] Data, Int32 StartIndex = 0) {
                if (Data is null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                Int32 Out = 0;
                Int32 BitShift = 0;
                Byte Current;
                Int32 Index = StartIndex;

                do {
                    Current = Data[Index];
                    Out |= (Current & NonSignalMask) << BitShift;
                    BitShift += 7;
                    Index++;
                } while (Current >= BitConverter.VarInt.SignalMask);

                return Out;
            }

            /// <summary>Converts the given byte array into an <see cref="Int32"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="Count">The amount of bytes that have been read</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given byte array into an <see cref="Int32"/></returns>
            public static Int32 ToInt32(Byte[] Data, out Int32 Count, Int32 StartIndex = 0) {
                if (Data is null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                Int32 Out = 0;
                Int32 BitShift = 0;
                Byte Current;
                Int32 Index = StartIndex;

                do {
                    Current = Data[Index];
                    Out |= (Current & NonSignalMask) << BitShift;
                    BitShift += 7;
                    Index++;
                } while (Current >= BitConverter.VarInt.SignalMask);

                Count = Index - StartIndex;

                return Out;
            }

            /// <summary>Converts the given byte array into an <see cref="Int32"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given byte array into an <see cref="Int32"/></returns>
            public static Int64 ToInt64(Byte[] Data, Int32 StartIndex = 0) {
                if (Data is null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                Int64 Out = 0;
                Int32 BitShift = 0;
                Byte Current;
                Int32 Index = StartIndex;

                do {
                    Current = Data[Index];
                    Out |= (Int64)(((Int64)(Current & NonSignalMask)) << BitShift);
                    BitShift += 7;
                    Index++;
                } while (Current >= BitConverter.VarInt.SignalMask);

                return Out;
            }

            /// <summary>Converts the given byte array into an <see cref="Int64"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="Count">The amount of bytes that have been read</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given byte array into an <see cref="Int64"/></returns>
            public static Int64 ToInt64(Byte[] Data, out Int32 Count, Int32 StartIndex = 0) {
                if (Data is null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                Int64 Out = 0;
                Int32 BitShift = 0;
                Byte Current;
                Int32 Index = StartIndex;

                do {
                    Current = Data[Index];
                    Out |= (Int64)((Current & NonSignalMask) << BitShift);
                    BitShift += 7;
                    Index++;
                } while (Current >= BitConverter.VarInt.SignalMask);

                Count = Index - StartIndex;

                return Out;
            }
        }
    }
}