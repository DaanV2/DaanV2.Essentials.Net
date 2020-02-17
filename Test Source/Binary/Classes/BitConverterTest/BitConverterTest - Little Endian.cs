using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Binary {
    [TestClass]
    public partial class BitConverterTest {
        [TestClass]
        public partial class LittleEndian {
            /// <summary>
            /// 
            /// </summary>
            [TestMethod]
            public void IsActuallyLittleEndian() {
                if (BitConverter.IsLittleEndian) {
                    TestArray(BitConverter.GetBytes((Int16)25), DaanV2.Binary.BitConverter.LittleEndian.ToBytes((Int16)25));
                    TestArray(BitConverter.GetBytes(25), DaanV2.Binary.BitConverter.LittleEndian.ToBytes(25));
                    TestArray(BitConverter.GetBytes((Int64)25), DaanV2.Binary.BitConverter.LittleEndian.ToBytes((Int64)25));
                    TestArray(BitConverter.GetBytes((UInt16)25), DaanV2.Binary.BitConverter.LittleEndian.ToBytes((UInt16)25));
                    TestArray(BitConverter.GetBytes((UInt32)25), DaanV2.Binary.BitConverter.LittleEndian.ToBytes((UInt32)25));
                    TestArray(BitConverter.GetBytes((UInt64)25), DaanV2.Binary.BitConverter.LittleEndian.ToBytes((UInt64)25));
                }
                else {
                    throw new NotImplementedException();
                }
            }

            [TestMethod]
            public void Int16() {
                Byte[] lData = new Byte[sizeof(Int16)];
                Array.Copy(Data, 0, lData, 0, lData.Length);

                Int16 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToInt16(Data);
                TestArray(lData, DaanV2.Binary.BitConverter.LittleEndian.ToBytes(TestValue));

                if (!BitConverter.IsLittleEndian) {
                    Array.Reverse(lData);
                }

                Int16 V = BitConverter.ToInt16(lData, 0);

                Assert.IsTrue(TestValue == V, "Litte Endian is not little endian");
            }

            [TestMethod]
            public void Int16Start() {
                for (Int32 I = 0; I < Data.Length - sizeof(Int16); I++) {
                    Byte[] lData = new Byte[sizeof(Int16)];
                    Array.Copy(Data, I, lData, 0, lData.Length);

                    Int16 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToInt16(Data, I);
                    TestArray(lData, DaanV2.Binary.BitConverter.LittleEndian.ToBytes(TestValue));

                    if (!BitConverter.IsLittleEndian) {
                        Array.Reverse(lData);
                    }

                    Int16 V = BitConverter.ToInt16(lData, 0);

                    Assert.IsTrue(TestValue == V, "Big endian is not big endian");
                }
            }

            [TestMethod]
            public void Int32() {
                Byte[] lData = new Byte[sizeof(Int32)];
                Array.Copy(Data, 0, lData, 0, lData.Length);

                Int32 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToInt32(Data);
                TestArray(lData, DaanV2.Binary.BitConverter.LittleEndian.ToBytes(TestValue));

                if (!BitConverter.IsLittleEndian) {
                    Array.Reverse(lData);
                }

                Int32 V = BitConverter.ToInt32(lData, 0);

                Assert.IsTrue(TestValue == V, "Litte Endian is not little endian");
            }

            [TestMethod]
            public void Int32Start() {
                for (Int32 I = 0; I < Data.Length - sizeof(Int32); I++) {
                    Byte[] lData = new Byte[sizeof(Int32)];
                    Array.Copy(Data, I, lData, 0, lData.Length);

                    Int32 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToInt32(Data, I);
                    TestArray(lData, DaanV2.Binary.BitConverter.LittleEndian.ToBytes(TestValue));

                    if (!BitConverter.IsLittleEndian) {
                        Array.Reverse(lData);
                    }

                    Int32 V = BitConverter.ToInt32(lData, 0);

                    Assert.IsTrue(TestValue == V, "Big endian is not big endian");
                }
            }

            [TestMethod]
            public void Int64() {
                Byte[] lData = new Byte[sizeof(Int64)];
                Array.Copy(Data, 0, lData, 0, lData.Length);

                Int64 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToInt64(Data);
                TestArray(lData, DaanV2.Binary.BitConverter.LittleEndian.ToBytes(TestValue));

                if (!BitConverter.IsLittleEndian) {
                    Array.Reverse(lData);
                }

                Int64 V = BitConverter.ToInt64(lData, 0);

                Assert.IsTrue(TestValue == V, "Litte Endian is not little endian");
            }

            [TestMethod]
            public void Int64Start() {
                for (Int32 I = 0; I < Data.Length - sizeof(Int64); I++) {
                    Byte[] lData = new Byte[sizeof(Int64)];
                    Array.Copy(Data, I, lData, 0, lData.Length);

                    Int64 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToInt64(Data, I);
                    TestArray(lData, DaanV2.Binary.BitConverter.LittleEndian.ToBytes(TestValue));

                    if (!BitConverter.IsLittleEndian) {
                        Array.Reverse(lData);
                    }

                    Int64 V = BitConverter.ToInt64(lData, 0);

                    Assert.IsTrue(TestValue == V, "Big endian is not big endian");
                }
            }

            [TestMethod]
            public void UInt16() {
                Byte[] lData = new Byte[sizeof(UInt16)];
                Array.Copy(Data, 0, lData, 0, lData.Length);

                UInt16 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToUInt16(Data);
                TestArray(lData, DaanV2.Binary.BitConverter.LittleEndian.ToBytes(TestValue));

                if (!BitConverter.IsLittleEndian) {
                    Array.Reverse(lData);
                }

                UInt16 V = BitConverter.ToUInt16(lData, 0);

                Assert.IsTrue(TestValue == V, "Litte Endian is not little endian");
            }

            [TestMethod]
            public void UInt16Start() {
                for (Int32 I = 0; I < Data.Length - sizeof(UInt16); I++) {
                    Byte[] lData = new Byte[sizeof(UInt16)];
                    Array.Copy(Data, I, lData, 0, lData.Length);

                    UInt16 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToUInt16(Data, I);
                    TestArray(lData, DaanV2.Binary.BitConverter.LittleEndian.ToBytes(TestValue));

                    if (!BitConverter.IsLittleEndian) {
                        Array.Reverse(lData);
                    }

                    UInt16 V = BitConverter.ToUInt16(lData, 0);

                    Assert.IsTrue(TestValue == V, "Big endian is not big endian");
                }
            }

            [TestMethod]
            public void UInt32() {
                Byte[] lData = new Byte[sizeof(UInt32)];
                Array.Copy(Data, 0, lData, 0, lData.Length);

                UInt32 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToUInt32(Data);
                TestArray(lData, DaanV2.Binary.BitConverter.LittleEndian.ToBytes(TestValue));

                if (!BitConverter.IsLittleEndian) {
                    Array.Reverse(lData);
                }

                UInt32 V = BitConverter.ToUInt32(lData, 0);

                Assert.IsTrue(TestValue == V, "Litte Endian is not little endian");
            }

            [TestMethod]
            public void UInt32Start() {
                for (Int32 I = 0; I < Data.Length - sizeof(UInt32); I++) {
                    Byte[] lData = new Byte[sizeof(UInt32)];
                    Array.Copy(Data, I, lData, 0, lData.Length);

                    UInt32 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToUInt32(Data, I);
                    TestArray(lData, DaanV2.Binary.BitConverter.LittleEndian.ToBytes(TestValue));

                    if (!BitConverter.IsLittleEndian) {
                        Array.Reverse(lData);
                    }

                    UInt32 V = BitConverter.ToUInt32(lData, 0);

                    Assert.IsTrue(TestValue == V, "Big endian is not big endian");
                }
            }

            [TestMethod]
            public void UInt64() {
                Byte[] lData = new Byte[sizeof(UInt64)];
                Array.Copy(Data, 0, lData, 0, lData.Length);

                UInt64 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToUInt64(Data);
                TestArray(lData, DaanV2.Binary.BitConverter.LittleEndian.ToBytes(TestValue));

                if (!BitConverter.IsLittleEndian) {
                    Array.Reverse(lData);
                }

                UInt64 V = BitConverter.ToUInt64(lData, 0);

                Assert.IsTrue(TestValue == V, "Litte Endian is not little endian");
            }

            [TestMethod]
            public void UInt64Start() {
                for (Int32 I = 0; I < Data.Length - sizeof(UInt64); I++) {
                    Byte[] lData = new Byte[sizeof(UInt64)];
                    Array.Copy(Data, I, lData, 0, lData.Length);

                    UInt64 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToUInt64(Data, I);
                    TestArray(lData, DaanV2.Binary.BitConverter.LittleEndian.ToBytes(TestValue));

                    if (!BitConverter.IsLittleEndian) {
                        Array.Reverse(lData);
                    }

                    UInt64 V = BitConverter.ToUInt64(lData, 0);

                    Assert.IsTrue(TestValue == V, "Big endian is not big endian");
                }
            }

            [TestMethod]
            public void TestOntoInt16() {
                Byte[] Data;
                Byte[] Source;

                Data = BitConverter.GetBytes((Int16)25);
                Source = new Byte[Data.Length];
                DaanV2.Binary.BitConverter.LittleEndian.OntoBytes(Source, (Int16)25);
                TestArray(Data, Source);
            }

            [TestMethod]
            public void TestOntoInt32() {
                Byte[] Data;
                Byte[] Source;

                Data = BitConverter.GetBytes(25);
                Source = new Byte[Data.Length];
                DaanV2.Binary.BitConverter.LittleEndian.OntoBytes(Source, 25);
                TestArray(Data, Source);
            }

            [TestMethod]
            public void TestOntoInt64() {
                Byte[] Data;
                Byte[] Source;

                Data = BitConverter.GetBytes((Int64)25);
                Source = new Byte[Data.Length];
                DaanV2.Binary.BitConverter.LittleEndian.OntoBytes(Source, (Int64)25);
                TestArray(Data, Source);
            }

            [TestMethod]
            public void TestOntoUInt16() {
                Byte[] Data;
                Byte[] Source;

                Data = BitConverter.GetBytes((UInt16)25);
                Source = new Byte[Data.Length];
                DaanV2.Binary.BitConverter.LittleEndian.OntoBytes(Source, (UInt16)25);
                TestArray(Data, Source);
            }

            [TestMethod]
            public void TestOntoUInt32() {
                Byte[] Data;
                Byte[] Source;

                Data = BitConverter.GetBytes((UInt32)25);
                Source = new Byte[Data.Length];
                DaanV2.Binary.BitConverter.LittleEndian.OntoBytes(Source, (UInt32)25);
                TestArray(Data, Source);
            }

            [TestMethod]
            public void TestOntoUInt64() {
                Byte[] Data;
                Byte[] Source;

                Data = BitConverter.GetBytes((UInt64)25);
                Source = new Byte[Data.Length];
                DaanV2.Binary.BitConverter.LittleEndian.OntoBytes(Source, (UInt64)25);
                TestArray(Data, Source);
            }
        }
    }
}
