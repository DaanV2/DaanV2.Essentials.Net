﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Binary {
    public partial class BitConverterTest {
        [TestClass]
        public partial class BigEndian {
            [TestMethod]
            public void Int16() {
                Byte[] lData = new Byte[sizeof(Int16)];
                Array.Copy(Data, 0, lData, 0, lData.Length);

                Int16 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToInt16(Data);

                if (BitConverter.IsLittleEndian) {
                    Array.Reverse(lData);
                }

                Int16 V = BitConverter.ToInt16(lData, 0);

                Assert.IsTrue(TestValue == V, "Big endian is not big endian");
            }

            [TestMethod]
            public void Int16Start() {
                for (Int32 I = 0; I < Data.Length - sizeof(Int16); I++) {
                    Byte[] lData = new Byte[sizeof(Int16)];
                    Array.Copy(Data, I, lData, 0, lData.Length);

                    Int16 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToInt16(Data, I);

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
                Array.Copy(Data, 0, lData, 0, lData.Length);

                Int32 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToInt32(Data);

                if (BitConverter.IsLittleEndian) {
                    Array.Reverse(lData);
                }

                Int32 V = BitConverter.ToInt32(lData, 0);

                Assert.IsTrue(TestValue == V, "Big endian is not big endian");
            }

            [TestMethod]
            public void Int32Start() {
                for (Int32 I = 0; I < Data.Length - sizeof(Int32); I++) {
                    Byte[] lData = new Byte[sizeof(Int32)];
                    Array.Copy(Data, I, lData, 0, lData.Length);

                    Int32 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToInt32(Data, I);

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
                Array.Copy(Data, 0, lData, 0, lData.Length);

                Int64 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToInt64(Data);

                if (BitConverter.IsLittleEndian) {
                    Array.Reverse(lData);
                }

                Int64 V = BitConverter.ToInt64(lData, 0);

                Assert.IsTrue(TestValue == V, "Big endian is not big endian");
            }

            [TestMethod]
            public void Int64Start() {
                for (Int32 I = 0; I < Data.Length - sizeof(Int64); I++) {
                    Byte[] lData = new Byte[sizeof(Int64)];
                    Array.Copy(Data, I, lData, 0, lData.Length);

                    Int64 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToInt64(Data, I);

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
                Array.Copy(Data, 0, lData, 0, lData.Length);

                UInt16 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToUInt16(Data);

                if (BitConverter.IsLittleEndian) {
                    Array.Reverse(lData);
                }

                UInt16 V = BitConverter.ToUInt16(lData, 0);

                Assert.IsTrue(TestValue == V, "Big endian is not big endian");
            }

            [TestMethod]
            public void UInt16Start() {
                for (Int32 I = 0; I < Data.Length - sizeof(UInt16); I++) {
                    Byte[] lData = new Byte[sizeof(UInt16)];
                    Array.Copy(Data, I, lData, 0, lData.Length);

                    UInt16 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToUInt16(Data, I);

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
                Array.Copy(Data, 0, lData, 0, lData.Length);

                UInt32 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToUInt32(Data);

                if (BitConverter.IsLittleEndian) {
                    Array.Reverse(lData);
                }

                UInt32 V = BitConverter.ToUInt32(lData, 0);

                Assert.IsTrue(TestValue == V, "Big endian is not big endian");
            }

            [TestMethod]
            public void UInt32Start() {
                for (Int32 I = 0; I < Data.Length - sizeof(UInt32); I++) {
                    Byte[] lData = new Byte[sizeof(UInt32)];
                    Array.Copy(Data, I, lData, 0, lData.Length);

                    UInt32 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToUInt32(Data, I);

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
                Array.Copy(Data, 0, lData, 0, lData.Length);

                UInt64 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToUInt64(Data);

                if (BitConverter.IsLittleEndian) {
                    Array.Reverse(lData);
                }

                UInt64 V = BitConverter.ToUInt64(lData, 0);

                Assert.IsTrue(TestValue == V, "Big endian is not big endian");
            }

            [TestMethod]
            public void UInt64Start() {
                for (Int32 I = 0; I < Data.Length - sizeof(UInt64); I++) {
                    Byte[] lData = new Byte[sizeof(UInt64)];
                    Array.Copy(Data, I, lData, 0, lData.Length);

                    UInt64 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToUInt64(Data, I);

                    if (BitConverter.IsLittleEndian) {
                        Array.Reverse(lData);
                    }

                    UInt64 V = BitConverter.ToUInt64(lData, 0);

                    Assert.IsTrue(TestValue == V, "Big endian is not big endian");
                }
            }
        }

    }
}
