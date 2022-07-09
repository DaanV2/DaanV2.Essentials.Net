/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.IO;

namespace DaanV2.Binary {

    public static partial class BitConverter {
        public static partial class Varint {
            /// <summary>Read an <see cref="Int32"/> varint from stream</summary>
            /// <param name="stream">The stream to read from</param>
            /// <param name="Count">The amount of bytes that have been read</param>
            /// <returns>Read an <see cref="Int32"/> varint from stream</returns>
            public static Int32 ReadInt32(Stream stream, out Int32 Count) {
                Int32 Out = 0;
                Int32 BitShift = 0;
                Byte Current;
                Int32 Temp;
                Count = 0;

                do {
                    Temp = stream.ReadByte();
                    if (Temp < 0) break;

                    Current = (Byte)Temp;
                    Out |= (Current & _NonSignalMask) << BitShift;
                    BitShift += 7;
                    Count++;
                } while (Current >= _SignalMask);

                return Out;
            }

            /// <summary>Read an <see cref="Int64"/> varint from stream</summary>
            /// <param name="stream">The stream to read from</param>
            /// <param name="Count">The amount of bytes that have been read</param>
            /// <returns>Read an <see cref="Int64"/> varint from stream</returns>
            public static Int64 ReadInt64(Stream stream, out Int32 Count) {
                Int64 Out = 0;
                Int32 BitShift = 0;
                Byte Current;
                Int32 Temp;
                Count = 0;

                do {
                    Temp = stream.ReadByte();
                    if (Temp < 0) break;

                    Current = (Byte)Temp;
                    Out |= (Int64)(((Int64)Current & _NonSignalMask) << BitShift);
                    BitShift += 7;
                    Count++;
                } while (Current >= _SignalMask);

                return Out;
            }

            /// <summary>Read an <see cref="Int32"/> varint from stream</summary>
            /// <param name="stream">The stream to read from</param>
            /// <returns>Read an <see cref="Int32"/> varint from stream</returns>
            public static Int32 ReadInt32(Stream stream) {
                Int32 Out = 0;
                Int32 BitShift = 0;
                Byte Current;

                do {
                    Current = (Byte)stream.ReadByte();
                    Out |= (Current & _NonSignalMask) << BitShift;
                    BitShift += 7;
                } while (Current >= _SignalMask);

                return Out;
            }

            /// <summary>Read an <see cref="Int64"/> varint from stream</summary>
            /// <param name="stream">The stream to read from</param>
            /// <returns>Read an <see cref="Int64"/> varint from stream</returns>
            public static Int64 ReadInt64(Stream stream) {
                Int64 Out = 0;
                Int32 BitShift = 0;
                Byte Current;

                do {
                    Current = (Byte)stream.ReadByte();
                    Out |= (Int64)((Current & _NonSignalMask) << BitShift);
                    BitShift += 7;
                } while (Current >= _SignalMask);

                return Out;
            }

            /// <summary>Writes a <see cref="Int32"/> varint to stream</summary>
            /// <param name="stream">The stream to write to</param>
            /// <param name="Value">The value to be written</param>
            /// <returns>Writes a <see cref="Int32"/> varint to stream</returns>
            public static void Write(Stream stream, Int32 Value) {
                UInt32 v = (UInt32)Value;

                while (v >= _SignalMask) {
                    stream.WriteByte((Byte)(v | _SignalMask));
                    v >>= 7;
                }

                stream.WriteByte((Byte)v);
            }

            /// <summary>Writes a <see cref="Int32"/> varint to stream</summary>
            /// <param name="stream">The stream to write to</param>
            /// <param name="Value">The value to be written</param>
            /// <returns>Writes a <see cref="Int32"/> varint to stream</returns>
            public static void Write(Stream stream, UInt32 Value) {
                while (Value >= _SignalMask) {
                    stream.WriteByte((Byte)(Value | _SignalMask));
                    Value >>= 7;
                }

                stream.WriteByte((Byte)Value);
            }

            /// <summary>Writes a <see cref="Int64"/> varint to stream</summary>
            /// <param name="stream">The stream to write to</param>
            /// <param name="Value">The value to be written</param>
            /// <returns>Writes a <see cref="Int64"/> varint to stream</returns>
            public static void Write(Stream stream, Int64 Value) {
                UInt64 v = (UInt64)Value;

                while (v >= _SignalMask) {
                    stream.WriteByte((Byte)(v | _SignalMask));
                    v >>= 7;
                }

                stream.WriteByte((Byte)v);
            }

            /// <summary>Writes a <see cref="Int64"/> varint to stream</summary>
            /// <param name="stream">The stream to write to</param>
            /// <param name="Value">The value to be written</param>
            /// <returns>Writes a <see cref="Int64"/> varint to stream</returns>
            public static void Write(Stream stream, UInt64 Value) {
                while (Value >= _SignalMask) {
                    stream.WriteByte((Byte)(Value | _SignalMask));
                    Value >>= 7;
                }

                stream.WriteByte((Byte)Value);
            }
        }
    }
}