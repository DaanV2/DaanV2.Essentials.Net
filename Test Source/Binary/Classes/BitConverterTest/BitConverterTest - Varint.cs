using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Binary {
    public partial class BitConverterTest {
        [TestClass]
        public partial class Varint {
            [TestMethod]
            public void TestInt32() {
                Int32 Step = Int32.MaxValue / 1000;

                for (Int32 I = 0; I < Int32.MaxValue && I > -1; I += Step) {
                    Byte[] Data = DaanV2.Binary.BitConverter.Varint.ToBytes(I);
                    Int32 NewValue = DaanV2.Binary.BitConverter.Varint.ToInt32(Data);

                    Assert.IsTrue(I == NewValue, $"Varint Int32 encoding/decoding failed at: {I} resulted in {NewValue}");
                }
            }

            [TestMethod]
            public void TestInt64() {
                Int64 Step = Int64.MaxValue / 1000;

                for (Int64 I = 0; I < Int64.MaxValue && I > -1; I+= Step) {
                    Byte[] Data = DaanV2.Binary.BitConverter.Varint.ToBytes(I);
                    Int64 NewValue = DaanV2.Binary.BitConverter.Varint.ToInt64(Data);

                    Assert.IsTrue(I == NewValue, $"Varint Int64 encoding/decoding failed at: {I} resulted in {NewValue}");
                }
            }
        }
    }
}