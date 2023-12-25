using System;
using System.Linq;
using DaanV2.Binary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Binary {
    public sealed partial class BitFlags8Test {
        [TestMethod]
        public void ToStringTest() {
            ToStringTest((BitFlags8)0b0000_0000);
            ToStringTest((BitFlags8)0b0000_0010);
            ToStringTest((BitFlags8)0b0000_0100);
            ToStringTest((BitFlags8)0b0000_1000);
            ToStringTest((BitFlags8)0b0001_0000);
            ToStringTest((BitFlags8)0b0010_0000);
            ToStringTest((BitFlags8)0b0100_0000);
            ToStringTest((BitFlags8)0b1000_0000);

            ToStringTest((BitFlags8)0b1111_1111);
        }

        public static void ToStringTest(BitFlags8 data) {
            ToStringTest(data.ToString());
        }

        public static void ToStringTest(String data) {
            Int32 Nulls = data.Count((c) => c == '0');
            Int32 Ones = data.Count((c) => c == '1');

            Assert.AreEqual(data.Length, Nulls + Ones);
        }
    }
}