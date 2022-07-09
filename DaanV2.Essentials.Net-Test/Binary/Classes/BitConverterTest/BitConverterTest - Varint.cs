using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Binary {
    public partial class BitConverterTest {
        [TestClass]
        public partial class Varint {
            private readonly (Int64 Value, Byte[] ExpectedResult)[] _DataSetsInt64 = new (Int64 Value, Byte[] ExpectedResult)[]{
                    DataSet(300, 0b1010_1100, 0b0000_0010), //Googles own examples
                    DataSet(0, 0b0000_0000), //Wiki examples
                    DataSet(127, 0b01111111), //Wiki examples
                    DataSet(128, 0b10000000, 0b00000001), //Wiki examples
                    DataSet(1048, 0b10011000, 0b00001000), //Wiki examples
                    DataSet(2_147_483_647, 0b11111111, 0b11111111, 0b11111111, 0b11111111, 0b00000111),
                    DataSet(2_147_483_648, 0b10000000, 0b10000000, 0b10000000, 0b10000000, 0b00001000),
                    DataSet(4147483648, 0b10000000, 0b10101000, 0b11010110, 0b10111001, 0b00001111),
                    DataSet(300),
                    DataSet(127),
                    DataSet(128),
                    DataSet(4147483648),
                    DataSet(1 << 7),
                    DataSet(1 << 8),
                    DataSet(1 << 14),
                    DataSet(1 << 15),
                    DataSet(1 << 21),
                    DataSet(1 << 22),
                    DataSet(1 << 28),
                    DataSet(1 << 29),
                    DataSet(1 << 35),
                    DataSet(1 << 36),
                    DataSet(1 << 42),
                    DataSet(1 << 43)
                };

            private readonly (Int32 Value, Byte[] ExpectedResult)[] _DataSetsInt32 = new (Int32 Value, Byte[] ExpectedResult)[]{
                    DataSet(300, 0b1010_1100, 0b0000_0010), //Googles own examples
                    DataSet(0, 0b0000_0000), //Wiki examples
                    DataSet(127, 0b01111111), //Wiki examples
                    DataSet(128, 0b10000000, 0b00000001), //Wiki examples
                    DataSet(1048, 0b10011000, 0b00001000), //Wiki examples
                    DataSet(2_147_483_647, 0b11111111, 0b11111111, 0b11111111, 0b11111111, 0b00000111),
                    DataSet(300),
                    DataSet(127),
                    DataSet(128),
                    DataSet(1 << 7),
                    DataSet(1 << 8),
                    DataSet(1 << 14),
                    DataSet(1 << 15),
                    DataSet(1 << 21),
                    DataSet(1 << 22),
                    DataSet(1 << 28),
                    DataSet(1 << 29),
                    DataSet(1 << 35),
                    DataSet(1 << 36),
                    DataSet(1 << 42),
                    DataSet(1 << 43)
                };

            [TestMethod]
            public void IsTestReliable() {
                this.TestDataSet(this._DataSetsInt64[0], this._DataSetsInt64[8]);
                this.TestDataSet(this._DataSetsInt64[2], this._DataSetsInt64[9]);
                this.TestDataSet(this._DataSetsInt64[3], this._DataSetsInt64[10]);
                this.TestDataSet(this._DataSetsInt64[7], this._DataSetsInt64[11]);

                this.TestDataSet(this._DataSetsInt32[0], this._DataSetsInt32[6]);
                this.TestDataSet(this._DataSetsInt32[2], this._DataSetsInt32[7]);
                this.TestDataSet(this._DataSetsInt32[3], this._DataSetsInt32[8]);
            }

            public void TestDataSet((Int64 Value, Byte[] ExpectedResult) A, (Int64 Value, Byte[] ExpectedResult) B) {
                Assert.IsTrue(A.Value == B.Value, "Dataset values are not the same");
                Assert.IsTrue(A.ExpectedResult.Length == B.ExpectedResult.Length, "Dataset are not the same length");

                for (Int32 I = 0; I < A.ExpectedResult.Length; I++) {
                    Assert.IsTrue(A.ExpectedResult[I] == B.ExpectedResult[I], "array is not the same");
                }
            }

            [TestMethod]
            public void TestVarintInt32FromBytes() {
                for (Int32 I = 0; I < this._DataSetsInt32.Length; I++) {
                    Int32 ExpectedValue = this._DataSetsInt32[I].Value;
                    Byte[] ExpectedResult = this._DataSetsInt32[I].ExpectedResult;
                    Int32 Count = DaanV2.Binary.BitConverter.Varint.ByteCount((UInt32)ExpectedValue);
                    Int32 ResultValue = DaanV2.Binary.BitConverter.Varint.ToInt32(ExpectedResult, 0);

                    Assert.IsTrue(Count == ExpectedResult.Length, "Expected count is wrong");
                    Assert.IsTrue(ExpectedValue == ResultValue, "Varint Conversion process failed");
                }
            }

            [TestMethod]
            public void TestVarintInt32ToBytes() {
                for (Int32 I = 0; I < this._DataSetsInt32.Length; I++) {
                    Int32 ExpectedValue = this._DataSetsInt32[I].Value;
                    Byte[] ExpectedResult = this._DataSetsInt32[I].ExpectedResult;
                    Byte[] ResultData = DaanV2.Binary.BitConverter.Varint.ToBytes(ExpectedValue);
                    Int32 Count = DaanV2.Binary.BitConverter.Varint.ByteCount(ExpectedValue);

                    Assert.IsTrue(Count == ExpectedResult.Length, "Expected result is wrong");
                    Assert.IsTrue(Count == ResultData.Length, "Result data is wrong");
                    TestArray(ResultData, ExpectedResult);
                }
            }

            [TestMethod]
            public void TestVarintInt64FromBytes() {
                for (Int32 I = 0; I < this._DataSetsInt64.Length; I++) {
                    Int64 ExpectedValue = this._DataSetsInt64[I].Value;
                    Byte[] ExpectedResult = this._DataSetsInt64[I].ExpectedResult;
                    Int32 Count = DaanV2.Binary.BitConverter.Varint.ByteCount((UInt64)ExpectedValue);
                    Int64 ResultValue = DaanV2.Binary.BitConverter.Varint.ToInt64(ExpectedResult, 0);

                    Assert.IsTrue(Count == ExpectedResult.Length, "Expected result is wrong");
                    Assert.IsTrue(ExpectedValue == ResultValue, $"Varint Conversion process failed: {ExpectedValue} result in: {ResultValue}");
                }
            }

            [TestMethod]
            public void TestVarintInt64ToBytes() {
                for (Int32 I = 0; I < this._DataSetsInt64.Length; I++) {
                    Int64 ExpectedValue = this._DataSetsInt64[I].Value;
                    Byte[] ExpectedResult = this._DataSetsInt64[I].ExpectedResult;
                    Byte[] ResultData = DaanV2.Binary.BitConverter.Varint.ToBytes(ExpectedValue);
                    Int32 Count = DaanV2.Binary.BitConverter.Varint.ByteCount(ExpectedValue);

                    Assert.IsTrue(Count == ExpectedResult.Length, "Expected result is wrong");
                    Assert.IsTrue(Count == ResultData.Length, "Result data is wrong");
                    TestArray(ResultData, ExpectedResult);
                }
            }

            [TestMethod]
            public void StreamTestInt32() {
                for (Int32 I = 0; I < this._DataSetsInt32.Length; I++) {
                    Int32 ExpectedValue = this._DataSetsInt32[I].Value;
                    Byte[] ExpectedResult = this._DataSetsInt32[I].ExpectedResult;

                    var Stream = new MemoryStream(ExpectedResult);
                    Int32 ResultValue = DaanV2.Binary.BitConverter.Varint.ReadInt32(Stream, out Int32 Count);

                    Assert.IsTrue(Count == ExpectedResult.Length, "Expected result is wrong");
                    Assert.IsTrue(ResultValue == ExpectedValue, $"Varint {ExpectedValue} went wrong, {ResultValue}");

                    Stream = new MemoryStream(new Byte[100]);
                    DaanV2.Binary.BitConverter.Varint.Write(Stream, ResultValue);

                    Assert.IsTrue(Stream.Position == ExpectedResult.Length, "Expected result is wrong");
                    Byte[] Data = Stream.ToArray();
                    Array.Resize(ref Data, (Int32)Stream.Position);
                    TestArray(Data, ExpectedResult);
                }
            }

            [TestMethod]
            public void StreamTestInt64() {
                for (Int32 I = 0; I < this._DataSetsInt64.Length; I++) {
                    Int64 ExpectedValue = this._DataSetsInt64[I].Value;
                    Byte[] ExpectedResult = this._DataSetsInt64[I].ExpectedResult;

                    var Stream = new MemoryStream(ExpectedResult);
                    Int64 ResultValue = DaanV2.Binary.BitConverter.Varint.ReadInt64(Stream, out Int32 Count);

                    Assert.IsTrue(Count == ExpectedResult.Length, "Expected result is wrong");
                    Assert.IsTrue(ResultValue == ExpectedValue, $"Varint {ExpectedValue} went wrong, {ResultValue}");

                    Stream = new MemoryStream(new Byte[100]);
                    DaanV2.Binary.BitConverter.Varint.Write(Stream, ResultValue);

                    Assert.IsTrue(Stream.Position == ExpectedResult.Length, "Expected result is wrong");
                    Byte[] Data = Stream.ToArray();
                    Array.Resize(ref Data, (Int32)Stream.Position);
                    TestArray(Data, ExpectedResult);
                }
            }

            [TestMethod]
            public void OntoByteArrayInt32() {
                for (Int32 I = 0; I < this._DataSetsInt32.Length; I++) {
                    Int32 ExpectedValue = this._DataSetsInt32[I].Value;
                    Byte[] ExpectedResult = this._DataSetsInt32[I].ExpectedResult;

                    Byte[] Array = new Byte[ExpectedResult.Length];
                    Int32 ResultValue = DaanV2.Binary.BitConverter.Varint.OntoBytes(Array, ExpectedValue, 0);

                    Assert.IsTrue(ResultValue == ExpectedResult.Length, "Expected result is wrong");
                    TestArray(Array, ExpectedResult);
                }
            }

            [TestMethod]
            public void OntoByteArrayInt64() {
                for (Int32 I = 0; I < this._DataSetsInt64.Length; I++) {
                    Int64 ExpectedValue = this._DataSetsInt64[I].Value;
                    Byte[] ExpectedResult = this._DataSetsInt64[I].ExpectedResult;

                    Byte[] Array = new Byte[ExpectedResult.Length];
                    Int32 ResultValue = DaanV2.Binary.BitConverter.Varint.OntoBytes(Array, ExpectedValue, 0);

                    Assert.IsTrue(ResultValue == ExpectedResult.Length, "Expected result is wrong");
                    TestArray(Array, ExpectedResult);
                }
            }
        }
    }
}