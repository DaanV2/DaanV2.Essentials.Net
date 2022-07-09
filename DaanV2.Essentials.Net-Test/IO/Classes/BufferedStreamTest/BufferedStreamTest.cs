using System;
using DaanV2.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.IO {
    [TestClass]
    public partial class BufferedStreamTest {
        public const Byte Fill = 255;

        [TestMethod]
        public void TestUInt16() {
            var Temp = new BufferedStreamTest.TestClass();
            TestRange(Temp.pBuffer, Temp.pUInt16Buffer, TestClass.UInt16_StartIndex);
        }

        [TestMethod]
        public void TestInt16() {
            var Temp = new BufferedStreamTest.TestClass();
            TestRange(Temp.pBuffer, Temp.pInt16Buffer, TestClass.Int16_StartIndex);
        }

        [TestMethod]
        public void TestUInt32() {
            var Temp = new BufferedStreamTest.TestClass();
            TestRange(Temp.pBuffer, Temp.pUInt32Buffer, TestClass.UInt32_StartIndex);
        }

        [TestMethod]
        public void TestInt32() {
            var Temp = new BufferedStreamTest.TestClass();
            TestRange(Temp.pBuffer, Temp.pInt32Buffer, TestClass.Int32_StartIndex);
        }

        [TestMethod]
        public void TestUInt64() {
            var Temp = new BufferedStreamTest.TestClass();
            TestRange(Temp.pBuffer, Temp.pUInt64Buffer, TestClass.UInt64_StartIndex);
        }

        [TestMethod]
        public void TestInt64() {
            var Temp = new BufferedStreamTest.TestClass();
            TestRange(Temp.pBuffer, Temp.pInt64Buffer, TestClass.Int64_StartIndex);
        }

        [TestMethod]
        public void TestNotOverlap() {
            var Temp = new BufferedStreamTest.TestClass();
            SetSafe(Temp.pInt16Buffer, 1);
            SetSafe(Temp.pUInt16Buffer, 2);
            SetSafe(Temp.pInt32Buffer, 3);
            SetSafe(Temp.pUInt32Buffer, 4);
            SetSafe(Temp.pInt64Buffer, 5);
            SetSafe(Temp.pUInt64Buffer, 6);
        }

        public static void TestRange(Span<Byte> Whole, Span<Byte> Area, Int32 StartIndex) {
            Area.Fill(Fill);

            foreach (Byte Item in Area) {
                Assert.AreEqual(Item, Fill, $"expected area to be filled with {Fill}");
            }

            for (Int32 I = 0; I < StartIndex; I++) {
                Assert.AreEqual(Whole[I], 0, "Illegal area filled");
            }

            for (Int32 I = StartIndex + Area.Length; I < Whole.Length; I++) {
                Assert.AreEqual(Whole[I], 0, "Illegal area filled");
            }
        }

        public static void SetSafe(Span<Byte> Data, Byte Set) {
            for (Int32 I = 0; I < Data.Length; I++) {
                Assert.AreEqual(Data[I], 0);
                Data[I] = Set;
            }
        }


        public class TestClass : BufferedStream {
            public TestClass() : base() { }

            public static Int32 UInt16_StartIndex => UInt16_Index;
            public static Int32 Int16_StartIndex => Int16_Index;
            public static Int32 UInt32_StartIndex => UInt32_Index;
            public static Int32 Int32_StartIndex => Int32_Index;
            public static Int32 UInt64_StartIndex => UInt64_Index;
            public static Int32 Int64_StartIndex => Int64_Index;

            public Span<Byte> pUInt16Buffer => this.UInt16Buffer();
            public Span<Byte> pInt16Buffer => this.Int16Buffer();
            public Span<Byte> pUInt32Buffer => this.UInt32Buffer();
            public Span<Byte> pInt32Buffer => this.Int32Buffer();
            public Span<Byte> pUInt64Buffer => this.UInt64Buffer();
            public Span<Byte> pInt64Buffer => this.Int64Buffer();

            public Span<Byte> pBuffer => this.Buffer();
            public override Boolean CanRead => throw new NotImplementedException();
            public override Boolean CanSeek => throw new NotImplementedException();
            public override Boolean CanWrite => throw new NotImplementedException();
            public override Int64 Length => throw new NotImplementedException();
            public override Int64 Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public override void Flush() {
                throw new NotImplementedException();
            }

            public override Int32 Read(Byte[] buffer, Int32 offset, Int32 count) {
                throw new NotImplementedException();
            }

            public override Int64 Seek(Int64 offset, System.IO.SeekOrigin origin) {
                throw new NotImplementedException();
            }

            public override void SetLength(Int64 value) {
                throw new NotImplementedException();
            }

            public override void Write(Byte[] buffer, Int32 offset, Int32 count) {
                throw new NotImplementedException();
            }
        }
    }
}