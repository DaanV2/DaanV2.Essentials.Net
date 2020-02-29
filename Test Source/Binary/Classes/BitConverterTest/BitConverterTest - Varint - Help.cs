using System;

namespace UnitTests.Binary {
    public partial class BitConverterTest {
        public partial class Varint {

            public static (Int64, Byte[]) DataSet(Int64 Value, params Byte[] Result) {
                return (Value, Result);
            }

            public static (Int64, Byte[]) DataSet(Int64 Value) {
                Byte[] Data = BitConverter.GetBytes(Value);
                Int32 ByteCount = Data.Length;
                Int32 BitCount = ByteCount * 8;
                Boolean[] Bits = new Boolean[BitCount];
                Byte[] Result = new Byte[10];
                Int32 I;

                for (I = 0; I < ByteCount; I++) {
                    BinaryRep(Data[I], Bits, I * 8);
                }
                
                Int32 Count = 0;

                for (I = 0; I < Result.Length; I++) {
                    Result[I] = ToBytes7(Bits, I * 7);

                    if (Result[I] > 0) {
                        Count = I + 1;
                    }
                }

                for (I = 0; I < Count - 1; I++) {
                    Result[I] |= 0b1000_0000;
                }

                Array.Resize(ref Result, Count);

                return (Value, Result);
            }

            public static (Int32, Byte[]) DataSet(Int32 Value, params Byte[] Result) {
                return (Value, Result);
            }

            public static (Int32, Byte[]) DataSet(Int32 Value) {
                Byte[] Data = BitConverter.GetBytes(Value);
                Int32 ByteCount = Data.Length;
                Int32 BitCount = ByteCount * 8;
                Boolean[] Bits = new Boolean[BitCount];
                Byte[] Result = new Byte[10];
                Int32 I;

                for (I = 0; I < ByteCount; I++) {
                    BinaryRep(Data[I], Bits, I * 8);
                }

                Int32 Count = 0;

                for (I = 0; I < Result.Length; I++) {
                    Result[I] = ToBytes7(Bits, I * 7);

                    if (Result[I] > 0) {
                        Count = I + 1;
                    }
                }

                for (I = 0; I < Count - 1; I++) {
                    Result[I] |= 0b1000_0000;
                }

                Array.Resize(ref Result, Count);

                return (Value, Result);
            }


            public static void BinaryRep(Byte B, Boolean[] Receiver, Int32 Index) {
                Receiver[Index++] = (B & 0b0000_0001) > 0;
                Receiver[Index++] = (B & 0b0000_0010) > 0;
                Receiver[Index++] = (B & 0b0000_0100) > 0;
                Receiver[Index++] = (B & 0b0000_1000) > 0;

                Receiver[Index++] = (B & 0b0001_0000) > 0;
                Receiver[Index++] = (B & 0b0010_0000) > 0;
                Receiver[Index++] = (B & 0b0100_0000) > 0;
                Receiver[Index++] = (B & 0b1000_0000) > 0;
            }

            public static Byte ToBytes7(Boolean[] Data, Int32 Index) {
                Byte Out = 0;
                Int32 Max = (Index + 7);
                if (Max > Data.Length)
                    Max = Data.Length;

                for (Int32 I = Index; I < Max; I++) {
                    Out |= (Byte)((Data[I] ? 1 : 0) << (I - Index));
                }

                return Out;
            }
        }
    }
}