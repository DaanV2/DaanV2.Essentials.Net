/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;

namespace DaanV2.Binary {
    
    public static partial class BitConverter {
        public static partial class LittleEndian {
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

                    Receiver[StartIndex] = *s;
                    Receiver[1 + StartIndex] = *(s + 1);
                }
#else
                for (Int32 I = 0; I < Count; I++) {
                    Receiver[I + StartIndex] = (Byte)(Value);
                    Value >>= 8;
                }
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

                    Receiver[StartIndex] = *s;
                    Receiver[1 + StartIndex] = *(s + 1);
                    Receiver[2 + StartIndex] = *(s + 2);
                    Receiver[3 + StartIndex] = *(s + 3);
                }
#else
                for (Int32 I = 0; I < Count; I++) {
                    Receiver[I + StartIndex] = (Byte)(Value);
                    Value >>= 8;
                }
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

                    Receiver[StartIndex] = *s;
                    Receiver[1 + StartIndex] = *(s + 1);
                    Receiver[2 + StartIndex] = *(s + 2);
                    Receiver[3 + StartIndex] = *(s + 3);
                    Receiver[4 + StartIndex] = *(s + 4);
                    Receiver[5 + StartIndex] = *(s + 5);
                    Receiver[6 + StartIndex] = *(s + 6);
                    Receiver[7 + StartIndex] = *(s + 7);
                }
#else
                for (Int32 I = 0; I < Count; I++) {
                    Receiver[I + StartIndex] = (Byte)(Value);
                    Value >>= 8;
                }
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

                    Receiver[StartIndex] = *s;
                    Receiver[1 + StartIndex] = *(s + 1);
                }
#else
                for (Int32 I = 0; I < Count; I++) {
                    Receiver[I + StartIndex] = (Byte)(Value);
                    Value >>= 8;
                }
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

                    Receiver[StartIndex] = *s;
                    Receiver[1 + StartIndex] = *(s + 1);
                    Receiver[2 + StartIndex] = *(s + 2);
                    Receiver[3 + StartIndex] = *(s + 3);
                }
#else
                for (Int32 I = 0; I < Count; I++) {
                    Receiver[I + StartIndex] = (Byte)(Value);
                    Value >>= 8;
                }
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

                    Receiver[StartIndex] = *s;
                    Receiver[1 + StartIndex] = *(s + 1);
                    Receiver[2 + StartIndex] = *(s + 2);
                    Receiver[3 + StartIndex] = *(s + 3);
                    Receiver[4 + StartIndex] = *(s + 4);
                    Receiver[5 + StartIndex] = *(s + 5);
                    Receiver[6 + StartIndex] = *(s + 6);
                    Receiver[7 + StartIndex] = *(s + 7);
                }
#else
                for (Int32 I = 0; I < Count; I++) {
                    Receiver[I + StartIndex] = (Byte)(Value);
                    Value >>= 8;
                }
#endif

                return Count;
            }
        }
    }
}
