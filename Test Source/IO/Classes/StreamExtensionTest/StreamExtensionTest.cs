using System;
using System.IO;
using DaanV2.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.IO {
    ///DOLATER <summary>add description for class: StreamExtensionTest</summary>
    [TestClass]
    public partial class StreamExtensionTest {
        [TestMethod]
        public void ReadInt32BigEndian() {
            MemoryStream Stream = new MemoryStream(new Byte[] { 0xAA, 0xBB, 0xCC, 0xDD });
            Int32 Out = Stream.ReadBigEndian();

            Byte[] Data = BitConverter.GetBytes(Out);

            if (BitConverter.IsLittleEndian) {
                Assert.IsTrue(Data[0] == 0xDD, "Is not big endian");
                Assert.IsTrue(Data[1] == 0xCC, "Is not big endian");
                Assert.IsTrue(Data[2] == 0xBB, "Is not big endian");
                Assert.IsTrue(Data[3] == 0xAA, "Is not big endian");
            }
            else {
                Assert.IsTrue(Data[0] == 0xAA, "Is not big endian");
                Assert.IsTrue(Data[1] == 0xBB, "Is not big endian");
                Assert.IsTrue(Data[2] == 0xCC, "Is not big endian");
                Assert.IsTrue(Data[3] == 0xDD, "Is not big endian");
            }
        }

        [TestMethod]
        public void ReadInt32LittleEndian() {
            MemoryStream Stream = new MemoryStream(new Byte[] { 0xAA, 0xBB, 0xCC, 0xDD });
            Int32 Out = Stream.ReadLittleEndian();

            Byte[] Data = BitConverter.GetBytes(Out);

            if (!BitConverter.IsLittleEndian) {
                Assert.IsTrue(Data[0] == 0xDD, "Is not little endian");
                Assert.IsTrue(Data[1] == 0xCC, "Is not little endian");
                Assert.IsTrue(Data[2] == 0xBB, "Is not little endian");
                Assert.IsTrue(Data[3] == 0xAA, "Is not little endian");
            }
            else {
                Assert.IsTrue(Data[0] == 0xAA, "Is not little endian");
                Assert.IsTrue(Data[1] == 0xBB, "Is not little endian");
                Assert.IsTrue(Data[2] == 0xCC, "Is not little endian");
                Assert.IsTrue(Data[3] == 0xDD, "Is not little endian");
            }
        }
    }
}
