using System;
using System.IO;
using DaanV2.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.IO {
    public partial class StreamExtensionTest {
        [TestClass]
        public partial class BigEndian {
            [TestMethod]
            public void Int16() {
                MemoryStream Memory = new MemoryStream(Data);
                Byte[] lData = new Byte[sizeof(Int16)];
                Array.Copy(Data, 0, lData, 0, lData.Length);

                Int16 TestValue = Memory.BigEndian_ReadInt16();

                if (BitConverter.IsLittleEndian) {
                    Array.Reverse(lData);
                }

                Int16 V = BitConverter.ToInt16(lData, 0);

                Assert.IsTrue(TestValue == V, "Big endian is not big endian");
            }

            [TestMethod]
            public void Int32() {
                MemoryStream Memory = new MemoryStream(Data);
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
            public void Int64() {
                MemoryStream Memory = new MemoryStream(Data);
                Byte[] lData = new Byte[sizeof(Int64)];
                Array.Copy(Data, 0, lData, 0, lData.Length);

                Int64 TestValue = DaanV2.Binary.BitConverter.BigEndian.ToInt64(Data);

                if (BitConverter.IsLittleEndian) {
                    Array.Reverse(lData);
                }

                Int64 V = BitConverter.ToInt64(lData, 0);

                Assert.IsTrue(TestValue == V, "Big endian is not big endian");
            }
        }
    }
}
