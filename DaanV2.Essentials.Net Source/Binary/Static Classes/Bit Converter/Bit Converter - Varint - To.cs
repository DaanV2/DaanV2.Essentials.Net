/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.


THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;

namespace DaanV2.Binary {
    
    public static partial class BitConverter {
        public static partial class Varint {
            /// <summary>Converts the given byte array into an <see cref="Int32"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given byte array into an <see cref="Int32"/></returns>
            public static Int32 ToInt32(Byte[] Data, Int32 StartIndex = 0) {
                if (Data == null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                Int32 Out = 0;
                Int32 BitShift = 0;
                Byte Current;
                Int32 Index = StartIndex;

                do {
                    Current = Data[Index];
                    Out |= (Current & _NonSignalMask) << BitShift;
                    BitShift += 7;
                    Index++;
                } while (Current >= BitConverter.Varint._SignalMask);

                return Out;
            }

            /// <summary>Converts the given byte array into an <see cref="Int32"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="Count">The amount of bytes that have been read</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given byte array into an <see cref="Int32"/></returns>
            public static Int32 ToInt32(Byte[] Data, out Int32 Count, Int32 StartIndex = 0) {
                if (Data == null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                Int32 Out = 0;
                Int32 BitShift = 0;
                Byte Current;
                Int32 Index = StartIndex;

                do {
                    Current = Data[Index];
                    Out |= (Current & _NonSignalMask) << BitShift;
                    BitShift += 7;
                    Index++;
                } while (Current >= BitConverter.Varint._SignalMask);

                Count = Index - StartIndex;

                return Out;
            }

            /// <summary>Converts the given byte array into an <see cref="Int32"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given byte array into an <see cref="Int32"/></returns>
            public static Int64 ToInt64(Byte[] Data, Int32 StartIndex = 0) {
                if (Data == null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                Int64 Out = 0;
                Int32 BitShift = 0;
                Byte Current;
                Int32 Index = StartIndex;

                do {
                    Current = Data[Index];
                    Out |= (Int64)(((Int64)(Current & _NonSignalMask)) << BitShift);
                    BitShift += 7;
                    Index++;
                } while (Current >= BitConverter.Varint._SignalMask);

                return Out;
            }

            /// <summary>Converts the given byte array into an <see cref="Int64"/></summary>
            /// <param name="Data">The byte array to convert</param>
            /// <param name="Count">The amount of bytes that have been read</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given byte array into an <see cref="Int64"/></returns>
            public static Int64 ToInt64(Byte[] Data, out Int32 Count, Int32 StartIndex = 0) {
                if (Data == null) {
                    throw new ArgumentNullException(nameof(Data));
                }

                Int64 Out = 0;
                Int32 BitShift = 0;
                Byte Current;
                Int32 Index = StartIndex;

                do {
                    Current = Data[Index];
                    Out |= (Int64)((Current & _NonSignalMask) << BitShift);
                    BitShift += 7;
                    Index++;
                } while (Current >= BitConverter.Varint._SignalMask);

                Count = Index - StartIndex;

                return Out;
            }
        }
    }
}
