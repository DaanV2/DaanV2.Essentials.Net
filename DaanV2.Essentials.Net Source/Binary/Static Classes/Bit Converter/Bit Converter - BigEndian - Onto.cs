/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or withReceiver fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.


THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING Receiver OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;

namespace DaanV2.Binary {
    
    public static partial class BitConverter {
        public static partial class BigEndian {
            /// <summary>Converts the given object into a byte array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a byte array</returns>
            public static Int32 OntoBytes(Byte[] Receiver, Int16 Value, Int32 StartIndex = 0) {
                if (Receiver is null) {
                    throw new ArgumentNullException(nameof(Receiver));
                }

                Int32 Count = sizeof(Int16);
                if (StartIndex + Count > Receiver.Length) {
                    throw new ArgumentException("Receiver is not of proper length");
                }

#if UNSAFE
                unsafe {
                    Byte* s = (Byte*)&Value;

                    Receiver[1 + StartIndex] = *s;
                    Receiver[StartIndex] = *(s + 1);
                }
#else
                Receiver[1 + StartIndex] = (Byte)(Value & BitConverter._ByteOnlyMask);
                Receiver[StartIndex] = (Byte)((Value >> 8) & BitConverter._ByteOnlyMask);
#endif

                return Count;
            }

            /// <summary>Converts the given object into a byte array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a byte array</returns>
            public static Int32 OntoBytes(Byte[] Receiver, Int32 Value, Int32 StartIndex = 0) {
                if (Receiver is null) {
                    throw new ArgumentNullException(nameof(Receiver));
                }

                Int32 Count = sizeof(Int32);
                if (StartIndex + Count > Receiver.Length) {
                    throw new ArgumentException("Receiver is not of proper length");
                }

#if UNSAFE
                unsafe {
                    Byte* s = (Byte*)&Value;

                    Receiver[3 + StartIndex] = *s;
                    Receiver[2 + StartIndex] = *(s + 1);
                    Receiver[1 + StartIndex] = *(s + 2);
                    Receiver[StartIndex] = *(s + 3);
                }
#else
                Receiver[3 + StartIndex] = (Byte)(Value & BitConverter._ByteOnlyMask);
                Receiver[2 + StartIndex] = (Byte)((Value >> 8) & BitConverter._ByteOnlyMask);
                Receiver[1 + StartIndex] = (Byte)((Value >> 16) & BitConverter._ByteOnlyMask);
                Receiver[StartIndex] = (Byte)((Value >> 24) & BitConverter._ByteOnlyMask);
#endif

                return Count;
            }

            /// <summary>Converts the given object into a byte array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a byte array</returns>
            public static Int32 OntoBytes(Byte[] Receiver, Int64 Value, Int32 StartIndex = 0) {
                if (Receiver is null) {
                    throw new ArgumentNullException(nameof(Receiver));
                }

                Int32 Count = sizeof(Int64);
                if (StartIndex + Count > Receiver.Length) {
                    throw new ArgumentException("Receiver is not of proper length");
                }

#if UNSAFE
                unsafe {
                    Byte* s = (Byte*)&Value;

                    Receiver[7 + StartIndex] = *s;
                    Receiver[6 + StartIndex] = *(s + 1);
                    Receiver[5 + StartIndex] = *(s + 2);
                    Receiver[4 + StartIndex] = *(s + 3);
                    Receiver[3 + StartIndex] = *(s + 4);
                    Receiver[2 + StartIndex] = *(s + 5);
                    Receiver[1 + StartIndex] = *(s + 6);
                    Receiver[StartIndex] = *(s + 7);
                }
#else
                Receiver[7 + StartIndex] = (Byte)(Value & BitConverter._ByteOnlyMask);
                Receiver[6 + StartIndex] = (Byte)((Value >> 8) & BitConverter._ByteOnlyMask);
                Receiver[5 + StartIndex] = (Byte)((Value >> 16) & BitConverter._ByteOnlyMask);
                Receiver[4 + StartIndex] = (Byte)((Value >> 24) & BitConverter._ByteOnlyMask);
                Receiver[3 + StartIndex] = (Byte)((Value >> 32) & BitConverter._ByteOnlyMask);
                Receiver[2 + StartIndex] = (Byte)((Value >> 40) & BitConverter._ByteOnlyMask);
                Receiver[1 + StartIndex] = (Byte)((Value >> 48) & BitConverter._ByteOnlyMask);
                Receiver[StartIndex] = (Byte)((Value >> 56) & BitConverter._ByteOnlyMask);
#endif

                return Count;
            }

            /// <summary>Converts the given object into a byte array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a byte array</returns>
            public static Int32 OntoBytes(Byte[] Receiver, UInt16 Value, Int32 StartIndex = 0) {
                if (Receiver is null) {
                    throw new ArgumentNullException(nameof(Receiver));
                }

                Int32 Count = sizeof(UInt16);
                if (StartIndex + Count > Receiver.Length) {
                    throw new ArgumentException("Receiver is not of proper length");
                }

#if UNSAFE
                unsafe {
                    Byte* s = (Byte*)&Value;

                    Receiver[1 + StartIndex] = *s;
                    Receiver[StartIndex] = *(s + 1);
                }
#else
                Receiver[1 + StartIndex] = (Byte)(Value & BitConverter._ByteOnlyMask);
                Receiver[StartIndex] = (Byte)((Value >> 8) & BitConverter._ByteOnlyMask);
#endif

                return Count;
            }

            /// <summary>Converts the given object into a byte array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a byte array</returns>
            public static Int32 OntoBytes(Byte[] Receiver, UInt32 Value, Int32 StartIndex = 0) {
                if (Receiver is null) {
                    throw new ArgumentNullException(nameof(Receiver));
                }

                Int32 Count = sizeof(UInt32);
                if (StartIndex + Count > Receiver.Length) {
                    throw new ArgumentException("Receiver is not of proper length");
                }

#if UNSAFE
                unsafe {
                    Byte* s = (Byte*)&Value;

                    Receiver[3 + StartIndex] = *s;
                    Receiver[2 + StartIndex] = *(s + 1);
                    Receiver[1 + StartIndex] = *(s + 2);
                    Receiver[StartIndex] = *(s + 3);
                }
#else
                Receiver[3 + StartIndex] = (Byte)(Value & BitConverter._ByteOnlyMask);
                Receiver[2 + StartIndex] = (Byte)((Value >> 8) & BitConverter._ByteOnlyMask);
                Receiver[1 + StartIndex] = (Byte)((Value >> 16) & BitConverter._ByteOnlyMask);
                Receiver[StartIndex] = (Byte)((Value >> 24) & BitConverter._ByteOnlyMask);
#endif

                return Count;
            }

            /// <summary>Converts the given object into a byte array</summary>
            /// <param name="Receiver">The array that receives the final data.</param>
            /// <param name="Value">The object to convert</param>
            /// <param name="StartIndex">The startindex for the data</param>
            /// <returns>Converts the given object into a byte array</returns>
            public static Int32 OntoBytes(Byte[] Receiver, UInt64 Value, Int32 StartIndex = 0) {
                if (Receiver is null) {
                    throw new ArgumentNullException(nameof(Receiver));
                }

                Int32 Count = sizeof(UInt64);
                if (StartIndex + Count > Receiver.Length) {
                    throw new ArgumentException("Receiver is not of proper length");
                }

#if UNSAFE
                unsafe {
                    Byte* s = (Byte*)&Value;

                    Receiver[7 + StartIndex] = *s;
                    Receiver[6 + StartIndex] = *(s + 1);
                    Receiver[5 + StartIndex] = *(s + 2);
                    Receiver[4 + StartIndex] = *(s + 3);
                    Receiver[3 + StartIndex] = *(s + 4);
                    Receiver[2 + StartIndex] = *(s + 5);
                    Receiver[1 + StartIndex] = *(s + 6);
                    Receiver[StartIndex] = *(s + 7);
                }
#else
                Receiver[7 + StartIndex] = (Byte)(Value & BitConverter._ByteOnlyMask);
                Receiver[6 + StartIndex] = (Byte)((Value >> 8) & BitConverter._ByteOnlyMask);
                Receiver[5 + StartIndex] = (Byte)((Value >> 16) & BitConverter._ByteOnlyMask);
                Receiver[4 + StartIndex] = (Byte)((Value >> 24) & BitConverter._ByteOnlyMask);
                Receiver[3 + StartIndex] = (Byte)((Value >> 32) & BitConverter._ByteOnlyMask);
                Receiver[2 + StartIndex] = (Byte)((Value >> 40) & BitConverter._ByteOnlyMask);
                Receiver[1 + StartIndex] = (Byte)((Value >> 48) & BitConverter._ByteOnlyMask);
                Receiver[StartIndex] = (Byte)((Value >> 56) & BitConverter._ByteOnlyMask);
#endif

                return Count;
            }
        }
    }
}
