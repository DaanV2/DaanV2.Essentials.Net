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
                Assert.IsTrue(BitConverter.LittleEndian.ToInt16(BitConverterTest.Original) == BitConverter.Endian.ToInt16(BitConverterTest.Original, Endianness.LittleEndian));
                Assert.IsTrue(BitConverter.LittleEndian.ToInt32(BitConverterTest.Original) == BitConverter.Endian.ToInt32(BitConverterTest.Original, Endianness.LittleEndian));
                Assert.IsTrue(BitConverter.LittleEndian.ToInt64(BitConverterTest.Original) == BitConverter.Endian.ToInt64(BitConverterTest.Original, Endianness.LittleEndian));
                Assert.IsTrue(BitConverter.LittleEndian.ToUInt16(BitConverterTest.Original) == BitConverter.Endian.ToUInt16(BitConverterTest.Original, Endianness.LittleEndian));
                Assert.IsTrue(BitConverter.LittleEndian.ToUInt32(BitConverterTest.Original) == BitConverter.Endian.ToUInt32(BitConverterTest.Original, Endianness.LittleEndian));
                Assert.IsTrue(BitConverter.LittleEndian.ToUInt64(BitConverterTest.Original) == BitConverter.Endian.ToUInt64(BitConverterTest.Original, Endianness.LittleEndian));


                TestArray(BitConverter.LittleEndian.ToBytes((System.Int16)0), BitConverter.Endian.ToBytes((System.Int16)0, Endianness.LittleEndian));
                TestArray(BitConverter.LittleEndian.ToBytes(0), BitConverter.Endian.ToBytes(0, Endianness.LittleEndian));
                TestArray(BitConverter.LittleEndian.ToBytes((System.Int64)0), BitConverter.Endian.ToBytes((System.Int64)0, Endianness.LittleEndian));
                TestArray(BitConverter.LittleEndian.ToBytes((System.UInt16)0), BitConverter.Endian.ToBytes((System.UInt16)0, Endianness.LittleEndian));
                TestArray(BitConverter.LittleEndian.ToBytes((System.UInt32)0), BitConverter.Endian.ToBytes((System.UInt32)0, Endianness.LittleEndian));
                TestArray(BitConverter.LittleEndian.ToBytes((System.UInt64)0), BitConverter.Endian.ToBytes((System.UInt64)0, Endianness.LittleEndian));
            }

            [TestMethod]
            public void BigEndianTest() {
                Assert.IsTrue(BitConverter.BigEndian.ToInt16(BitConverterTest.Original) == BitConverter.Endian.ToInt16(BitConverterTest.Original, Endianness.BigEndian));
                Assert.IsTrue(BitConverter.BigEndian.ToInt32(BitConverterTest.Original) == BitConverter.Endian.ToInt32(BitConverterTest.Original, Endianness.BigEndian));
                Assert.IsTrue(BitConverter.BigEndian.ToInt64(BitConverterTest.Original) == BitConverter.Endian.ToInt64(BitConverterTest.Original, Endianness.BigEndian));
                Assert.IsTrue(BitConverter.BigEndian.ToUInt16(BitConverterTest.Original) == BitConverter.Endian.ToUInt16(BitConverterTest.Original, Endianness.BigEndian));
                Assert.IsTrue(BitConverter.BigEndian.ToUInt32(BitConverterTest.Original) == BitConverter.Endian.ToUInt32(BitConverterTest.Original, Endianness.BigEndian));
                Assert.IsTrue(BitConverter.BigEndian.ToUInt64(BitConverterTest.Original) == BitConverter.Endian.ToUInt64(BitConverterTest.Original, Endianness.BigEndian));

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