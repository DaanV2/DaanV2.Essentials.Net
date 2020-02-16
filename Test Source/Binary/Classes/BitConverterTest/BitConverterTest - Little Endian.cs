using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Binary {
    ///DOLATER <summary>add description for class: BitConverterTest</summary>
    [TestClass]
    public partial class BitConverterTest {
        [TestClass]
        public partial class LittleEndian {
            [TestMethod]
            public void Int16() {
                Byte[] lData = BitConverterTest.Data;

                Int16 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToInt16(Data);

                if (!BitConverter.IsLittleEndian) {
                    Array.Reverse(Data);
                }

                Int16 V = BitConverter.ToInt16(Data, 0);

                Assert.IsTrue(TestValue == V, "Litte Endian is not little endian");
            }

            [TestMethod]
            public void Int16Start() {
                Byte[] lData = BitConverterTest.Data;

                for (Int32 I = 0; I < lData.Length - sizeof(Int16); I++) {
                    Int16 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToInt16(Data, I);

                    if (!BitConverter.IsLittleEndian) {
                        Array.Reverse(lData);
                    }

                    Int16 V = BitConverter.ToInt16(Data, I);

                    Assert.IsTrue(TestValue == V, "Litte Endian is not little endian");
                }
            }

            [TestMethod]
            public void Int32() {
                Byte[] lData = BitConverterTest.Data;

                Int32 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToInt32(Data);

                if (!BitConverter.IsLittleEndian) {
                    Array.Reverse(Data);
                }

                Int32 V = BitConverter.ToInt32(Data, 0);

                Assert.IsTrue(TestValue == V, "Litte Endian is not little endian");
            }

            [TestMethod]
            public void Int32Start() {
                Byte[] lData = BitConverterTest.Data;

                for (Int32 I = 0; I < lData.Length - sizeof(Int32); I++) {
                    Int32 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToInt32(Data, I);

                    if (!BitConverter.IsLittleEndian) {
                        Array.Reverse(lData);
                    }

                    Int32 V = BitConverter.ToInt32(Data, I);

                    Assert.IsTrue(TestValue == V, "Litte Endian is not little endian");
                }
            }

            [TestMethod]
            public void Int64() {
                Byte[] lData = BitConverterTest.Data;

                Int64 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToInt64(Data);

                if (!BitConverter.IsLittleEndian) {
                    Array.Reverse(Data);
                }

                Int64 V = BitConverter.ToInt64(Data, 0);

                Assert.IsTrue(TestValue == V, "Litte Endian is not little endian");
            }

            [TestMethod]
            public void Int64Start() {
                Byte[] lData = BitConverterTest.Data;

                for (Int32 I = 0; I < lData.Length - sizeof(Int64); I++) {
                    Int64 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToInt64(Data, I);

                    if (!BitConverter.IsLittleEndian) {
                        Array.Reverse(lData);
                    }

                    Int64 V = BitConverter.ToInt64(Data, I);

                    Assert.IsTrue(TestValue == V, "Litte Endian is not little endian");
                }
            }

            [TestMethod]
            public void UInt16() {
                Byte[] lData = BitConverterTest.Data;

                UInt16 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToUInt16(Data);

                if (!BitConverter.IsLittleEndian) {
                    Array.Reverse(Data);
                }

                UInt16 V = BitConverter.ToUInt16(Data, 0);

                Assert.IsTrue(TestValue == V, "Litte Endian is not little endian");
            }

            [TestMethod]
            public void UInt16Start() {
                Byte[] lData = BitConverterTest.Data;

                for (Int32 I = 0; I < lData.Length - sizeof(UInt16); I++) {
                    UInt16 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToUInt16(Data, I);

                    if (!BitConverter.IsLittleEndian) {
                        Array.Reverse(lData);
                    }

                    UInt16 V = BitConverter.ToUInt16(Data, I);

                    Assert.IsTrue(TestValue == V, "Litte Endian is not little endian");
                }
            }

            [TestMethod]
            public void UInt32() {
                Byte[] lData = BitConverterTest.Data;

                UInt32 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToUInt32(Data);

                if (!BitConverter.IsLittleEndian) {
                    Array.Reverse(Data);
                }

                UInt32 V = BitConverter.ToUInt32(Data, 0);

                Assert.IsTrue(TestValue == V, "Litte Endian is not little endian");
            }

            [TestMethod]
            public void UInt32Start() {
                Byte[] lData = BitConverterTest.Data;

                for (Int32 I = 0; I < lData.Length - sizeof(UInt32); I++) {
                    UInt32 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToUInt32(Data, I);

                    if (!BitConverter.IsLittleEndian) {
                        Array.Reverse(lData);
                    }

                    UInt32 V = BitConverter.ToUInt32(Data, I);

                    Assert.IsTrue(TestValue == V, "Litte Endian is not little endian");
                }
            }

            [TestMethod]
            public void UInt64() {
                Byte[] lData = BitConverterTest.Data;

                UInt64 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToUInt64(Data);

                if (!BitConverter.IsLittleEndian) {
                    Array.Reverse(Data);
                }

                UInt64 V = BitConverter.ToUInt64(Data, 0);

                Assert.IsTrue(TestValue == V, "Litte Endian is not little endian");
            }

            [TestMethod]
            public void UInt64Start() {
                Byte[] lData = BitConverterTest.Data;

                for (Int32 I = 0; I < lData.Length - sizeof(UInt64); I++) {
                    UInt64 TestValue = DaanV2.Binary.BitConverter.LittleEndian.ToUInt64(Data, I);

                    if (!BitConverter.IsLittleEndian) {
                        Array.Reverse(lData);
                    }

                    UInt64 V = BitConverter.ToUInt64(Data, I);

                    Assert.IsTrue(TestValue == V, "Litte Endian is not little endian");
                }
            }
        }
    }
}
