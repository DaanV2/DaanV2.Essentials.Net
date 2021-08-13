using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Binary {
    public partial class BitConverterTest {
        public partial class Endian {
            private const Int32 _Data = 0x0A0B0C0D;

            /// <summary>Tests if little endian is actually little endian</summary>
            [TestMethod]
            public void CheckLittleEndian() {
                Byte[] Data = DaanV2.Binary.BitConverter.LittleEndian.ToBytes(_Data);

                Assert.AreEqual(Data.Length, 4);

                Assert.AreEqual((Int32)Data[0], 0x0D);
                Assert.AreEqual((Int32)Data[1], 0x0C);
                Assert.AreEqual((Int32)Data[2], 0x0B);
                Assert.AreEqual((Int32)Data[3], 0x0A);
            }

            /// <summary>Tests if big endian is actually big endian</summary>
            [TestMethod]
            public void CheckBigEndian() {
                Byte[] Data = DaanV2.Binary.BitConverter.BigEndian.ToBytes(_Data);

                Assert.AreEqual(Data.Length, 4);

                Assert.AreEqual((Int32)Data[0], 0x0A);
                Assert.AreEqual((Int32)Data[1], 0x0B);
                Assert.AreEqual((Int32)Data[2], 0x0C);
                Assert.AreEqual((Int32)Data[3], 0x0D);
            }
        }
    }
}
