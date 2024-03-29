﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Binary {
    public partial class BitConverterTest {
        [TestClass]
        public partial class BigEndian {
            [TestMethod]
            public void Int16() {
                Byte[] lData = new Byte[sizeof(Int16)];
                Array.Copy(Original, 0, lData, 0, lData.Length);

                Int16 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToInt16(Original);
                TestArray(lData, DaanV2.Binary.BitConverter.BigEndian.ToBytes(TestValue));

                if (BitConverter.IsLittleEndian) {
                    Array.Reverse(lData);
                }

                Int16 V = BitConverter.ToInt16(lData, 0);

                Assert.IsTrue(TestValue == V, "Big endian is not big endian");
            }

            [TestMethod]
            public void Int16Start() {
                for (Int32 I = 0; I < Original.Length - sizeof(Int16); I++) {
                    Byte[] lData = new Byte[sizeof(Int16)];
                    Array.Copy(Original, I, lData, 0, lData.Length);

                    Int16 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToInt16(Original, I);
                    TestArray(lData, DaanV2.Binary.BitConverter.BigEndian.ToBytes(TestValue));

                    if (BitConverter.IsLittleEndian) {
                        Array.Reverse(lData);
                    }

                    Int16 V = BitConverter.ToInt16(lData, 0);

                    Assert.IsTrue(TestValue == V, "Big endian is not big endian");
                }
            }

            [TestMethod]
            public void Int32() {
                Byte[] lData = new Byte[sizeof(Int32)];
                Array.Copy(Original, 0, lData, 0, lData.Length);

                Int32 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToInt32(Original);
                TestArray(lData, DaanV2.Binary.BitConverter.BigEndian.ToBytes(TestValue));

                if (BitConverter.IsLittleEndian) {
                    Array.Reverse(lData);
                }

                Int32 V = BitConverter.ToInt32(lData, 0);

                Assert.IsTrue(TestValue == V, "Big endian is not big endian");
            }

            [TestMethod]
            public void Int32Start() {
                for (Int32 I = 0; I < Original.Length - sizeof(Int32); I++) {
                    Byte[] lData = new Byte[sizeof(Int32)];
                    Array.Copy(Original, I, lData, 0, lData.Length);

                    Int32 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToInt32(Original, I);
                    TestArray(lData, DaanV2.Binary.BitConverter.BigEndian.ToBytes(TestValue));

                    if (BitConverter.IsLittleEndian) {
                        Array.Reverse(lData);
                    }

                    Int32 V = BitConverter.ToInt32(lData, 0);

                    Assert.IsTrue(TestValue == V, "Big endian is not big endian");
                }
            }

            [TestMethod]
            public void Int64() {
                Byte[] lData = new Byte[sizeof(Int64)];
                Array.Copy(Original, 0, lData, 0, lData.Length);

                Int64 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToInt64(Original);
                TestArray(lData, DaanV2.Binary.BitConverter.BigEndian.ToBytes(TestValue));

                if (BitConverter.IsLittleEndian) {
                    Array.Reverse(lData);
                }

                Int64 V = BitConverter.ToInt64(lData, 0);

                Assert.IsTrue(TestValue == V, "Big endian is not big endian");
            }

            [TestMethod]
            public void Int64Start() {
                for (Int32 I = 0; I < Original.Length - sizeof(Int64); I++) {
                    Byte[] lData = new Byte[sizeof(Int64)];
                    Array.Copy(Original, I, lData, 0, lData.Length);

                    Int64 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToInt64(Original, I);
                    TestArray(lData, DaanV2.Binary.BitConverter.BigEndian.ToBytes(TestValue));

                    if (BitConverter.IsLittleEndian) {
                        Array.Reverse(lData);
                    }

                    Int64 V = BitConverter.ToInt64(lData, 0);

                    Assert.IsTrue(TestValue == V, "Big endian is not big endian");
                }
            }

            [TestMethod]
            public void UInt16() {
                Byte[] lData = new Byte[sizeof(UInt16)];
                Array.Copy(Original, 0, lData, 0, lData.Length);

                UInt16 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToUInt16(Original);
                TestArray(lData, DaanV2.Binary.BitConverter.BigEndian.ToBytes(TestValue));

                if (BitConverter.IsLittleEndian) {
                    Array.Reverse(lData);
                }

                UInt16 V = BitConverter.ToUInt16(lData, 0);

                Assert.IsTrue(TestValue == V, "Big endian is not big endian");
            }

            [TestMethod]
            public void UInt16Start() {
                for (Int32 I = 0; I < Original.Length - sizeof(UInt16); I++) {
                    Byte[] lData = new Byte[sizeof(UInt16)];
                    Array.Copy(Original, I, lData, 0, lData.Length);

                    UInt16 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToUInt16(Original, I);
                    TestArray(lData, DaanV2.Binary.BitConverter.BigEndian.ToBytes(TestValue));

                    if (BitConverter.IsLittleEndian) {
                        Array.Reverse(lData);
                    }

                    UInt16 V = BitConverter.ToUInt16(lData, 0);

                    Assert.IsTrue(TestValue == V, "Big endian is not big endian");
                }
            }

            [TestMethod]
            public void UInt32() {
                Byte[] lData = new Byte[sizeof(UInt32)];
                Array.Copy(Original, 0, lData, 0, lData.Length);

                UInt32 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToUInt32(Original);
                TestArray(lData, DaanV2.Binary.BitConverter.BigEndian.ToBytes(TestValue));

                if (BitConverter.IsLittleEndian) {
                    Array.Reverse(lData);
                }

                UInt32 V = BitConverter.ToUInt32(lData, 0);

                Assert.IsTrue(TestValue == V, "Big endian is not big endian");
            }

            [TestMethod]
            public void UInt32Start() {
                for (Int32 I = 0; I < Original.Length - sizeof(UInt32); I++) {
                    Byte[] lData = new Byte[sizeof(UInt32)];
                    Array.Copy(Original, I, lData, 0, lData.Length);

                    UInt32 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToUInt32(Original, I);
                    TestArray(lData, DaanV2.Binary.BitConverter.BigEndian.ToBytes(TestValue));

                    if (BitConverter.IsLittleEndian) {
                        Array.Reverse(lData);
                    }

                    UInt32 V = BitConverter.ToUInt32(lData, 0);

                    Assert.IsTrue(TestValue == V, "Big endian is not big endian");
                }
            }

            [TestMethod]
            public void UInt64() {
                Byte[] lData = new Byte[sizeof(UInt64)];
                Array.Copy(Original, 0, lData, 0, lData.Length);

                UInt64 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToUInt64(Original);
                TestArray(lData, DaanV2.Binary.BitConverter.BigEndian.ToBytes(TestValue));

                if (BitConverter.IsLittleEndian) {
                    Array.Reverse(lData);
                }

                UInt64 V = BitConverter.ToUInt64(lData, 0);

                Assert.IsTrue(TestValue == V, "Big endian is not big endian");
            }

            [TestMethod]
            public void UInt64Start() {
                for (Int32 I = 0; I < Original.Length - sizeof(UInt64); I++) {
                    Byte[] lData = new Byte[sizeof(UInt64)];
                    Array.Copy(Original, I, lData, 0, lData.Length);

                    UInt64 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToUInt64(Original, I);
                    TestArray(lData, DaanV2.Binary.BitConverter.BigEndian.ToBytes(TestValue));

                    if (BitConverter.IsLittleEndian) {
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
                Array.Reverse(Data);
                Source = new Byte[Data.Length];
                DaanV2.Binary.BitConverter.BigEndian.OntoBytes(Source, (Int16)25);
                TestArray(Data, Source);
            }

            [TestMethod]
            public void TestOntoInt32() {
                Byte[] Data;
                Byte[] Source;

                Data = BitConverter.GetBytes((Int32)25);
                Array.Reverse(Data);
                Source = new Byte[Data.Length];
                DaanV2.Binary.BitConverter.BigEndian.OntoBytes(Source, (Int32)25);
                TestArray(Data, Source);
            }

            [TestMethod]
            public void TestOntoInt64() {
                Byte[] Data;
                Byte[] Source;

                Data = BitConverter.GetBytes((Int64)25);
                Array.Reverse(Data);
                Source = new Byte[Data.Length];
                DaanV2.Binary.BitConverter.BigEndian.OntoBytes(Source, (Int64)25);
                TestArray(Data, Source);
            }

            [TestMethod]
            public void TestOntoUInt16() {
                Byte[] Data;
                Byte[] Source;

                Data = BitConverter.GetBytes((UInt16)25);
                Array.Reverse(Data);
                Source = new Byte[Data.Length];
                DaanV2.Binary.BitConverter.BigEndian.OntoBytes(Source, (UInt16)25);
                TestArray(Data, Source);
            }

            [TestMethod]
            public void TestOntoUInt32() {
                Byte[] Data;
                Byte[] Source;

                Data = BitConverter.GetBytes((UInt32)25);
                Array.Reverse(Data);
                Source = new Byte[Data.Length];
                DaanV2.Binary.BitConverter.BigEndian.OntoBytes(Source, (UInt32)25);
                TestArray(Data, Source);
            }

            [TestMethod]
            public void TestOntoUInt64() {
                Byte[] Data;
                Byte[] Source;

                Data = BitConverter.GetBytes((UInt64)25);
                Array.Reverse(Data);
                Source = new Byte[Data.Length];
                DaanV2.Binary.BitConverter.BigEndian.OntoBytes(Source, (UInt64)25);
                TestArray(Data, Source);
            }
        }
    }
}