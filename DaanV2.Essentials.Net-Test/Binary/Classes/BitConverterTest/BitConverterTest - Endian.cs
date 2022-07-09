using DaanV2.Binary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Binary {
    public partial class BitConverterTest {
        public static void TestArray(System.Byte[] DataA, System.Byte[] DataB) {
            if (DataA == null || DataB == null) {
                Assert.Fail("Arrays are null");
            }

            if (DataA.Length != DataB.Length) {
                Assert.Fail("Arrays are not the same length");
            }

            for (System.Int32 I = 0; I < DataA.Length; I++) {
                if (DataA[I] != DataB[I]) {
                    Assert.Fail("Arrays are not the same");
                }
            }
        }

        [TestClass]
        public partial class Endian {
            [TestMethod]
            public void LittleEndianTest() {
                Assert.IsTrue(BitConverter.LittleEndian.ToInt16(Data) == BitConverter.Endian.ToInt16(Data, Endianness.LittleEndian));
                Assert.IsTrue(BitConverter.LittleEndian.ToInt32(Data) == BitConverter.Endian.ToInt32(Data, Endianness.LittleEndian));
                Assert.IsTrue(BitConverter.LittleEndian.ToInt64(Data) == BitConverter.Endian.ToInt64(Data, Endianness.LittleEndian));
                Assert.IsTrue(BitConverter.LittleEndian.ToUInt16(Data) == BitConverter.Endian.ToUInt16(Data, Endianness.LittleEndian));
                Assert.IsTrue(BitConverter.LittleEndian.ToUInt32(Data) == BitConverter.Endian.ToUInt32(Data, Endianness.LittleEndian));
                Assert.IsTrue(BitConverter.LittleEndian.ToUInt64(Data) == BitConverter.Endian.ToUInt64(Data, Endianness.LittleEndian));


                TestArray(BitConverter.LittleEndian.ToBytes((System.Int16)0), BitConverter.Endian.ToBytes((System.Int16)0, Endianness.LittleEndian));
                TestArray(BitConverter.LittleEndian.ToBytes(0), BitConverter.Endian.ToBytes(0, Endianness.LittleEndian));
                TestArray(BitConverter.LittleEndian.ToBytes((System.Int64)0), BitConverter.Endian.ToBytes((System.Int64)0, Endianness.LittleEndian));
                TestArray(BitConverter.LittleEndian.ToBytes((System.UInt16)0), BitConverter.Endian.ToBytes((System.UInt16)0, Endianness.LittleEndian));
                TestArray(BitConverter.LittleEndian.ToBytes((System.UInt32)0), BitConverter.Endian.ToBytes((System.UInt32)0, Endianness.LittleEndian));
                TestArray(BitConverter.LittleEndian.ToBytes((System.UInt64)0), BitConverter.Endian.ToBytes((System.UInt64)0, Endianness.LittleEndian));
            }

            [TestMethod]
            public void BigEndianTest() {
                Assert.IsTrue(BitConverter.BigEndian.ToInt16(Data) == BitConverter.Endian.ToInt16(Data, Endianness.BigEndian));
                Assert.IsTrue(BitConverter.BigEndian.ToInt32(Data) == BitConverter.Endian.ToInt32(Data, Endianness.BigEndian));
                Assert.IsTrue(BitConverter.BigEndian.ToInt64(Data) == BitConverter.Endian.ToInt64(Data, Endianness.BigEndian));
                Assert.IsTrue(BitConverter.BigEndian.ToUInt16(Data) == BitConverter.Endian.ToUInt16(Data, Endianness.BigEndian));
                Assert.IsTrue(BitConverter.BigEndian.ToUInt32(Data) == BitConverter.Endian.ToUInt32(Data, Endianness.BigEndian));
                Assert.IsTrue(BitConverter.BigEndian.ToUInt64(Data) == BitConverter.Endian.ToUInt64(Data, Endianness.BigEndian));

                TestArray(BitConverter.BigEndian.ToBytes((System.Int16)0), BitConverter.Endian.ToBytes((System.Int16)0, Endianness.BigEndian));
                TestArray(BitConverter.BigEndian.ToBytes(0), BitConverter.Endian.ToBytes(0, Endianness.BigEndian));
                TestArray(BitConverter.BigEndian.ToBytes((System.Int64)0), BitConverter.Endian.ToBytes((System.Int64)0, Endianness.BigEndian));
                TestArray(BitConverter.BigEndian.ToBytes((System.UInt16)0), BitConverter.Endian.ToBytes((System.UInt16)0, Endianness.BigEndian));
                TestArray(BitConverter.BigEndian.ToBytes((System.UInt32)0), BitConverter.Endian.ToBytes((System.UInt32)0, Endianness.BigEndian));
                TestArray(BitConverter.BigEndian.ToBytes((System.UInt64)0), BitConverter.Endian.ToBytes((System.UInt64)0, Endianness.BigEndian));
            }
        }


    }
}