using System;
using System.Collections.Generic;
using System.Linq;
using DaanV2.Binary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Binary {
    public sealed partial class BitFlags8Test {
        [TestMethod]
        public void SanityTest() {
            for (Int32 B = 0; B < 256; B++) {
                var Flags = (BitFlags8)B;
                Boolean[] Arr = Flags.ToArray();

                Int32 CountA = Count(Flags);
                Int32 CountC = Flags.ToString().Count((c) => c == '1');

                Assert.AreEqual(CountA, CountC, "Something wrong with tostring");

                Test(Arr, Flags);
            }
        }

        [TestMethod]
        [DataRow(new Boolean[8] { true, true, true, true, true, true, true, true })]
        [DataRow(new Boolean[8] { false, true, false, true, false, true, false, true })]
        [DataRow(new Boolean[8] { true, false, true, false, true, false, true, false })]
        [DataRow(new Boolean[8] { false, false, false, false, false, false, false, false })]
        public void SanityTest(Boolean[] Arr) {
            Test(Arr);
        }

        public static void Test(Boolean[] Values) {
            var data = BitFlags8.From(Values);
            Test(Values, data);
        }

        public static void Test(Boolean[] Values, BitFlags8 data) {
            Assert.AreEqual(Values[0], data.Flag1, "Flag 1 is incorrect");
            Assert.AreEqual(Values[1], data.Flag2, "Flag 2 is incorrect");
            Assert.AreEqual(Values[2], data.Flag3, "Flag 3 is incorrect");
            Assert.AreEqual(Values[3], data.Flag4, "Flag 4 is incorrect");
            Assert.AreEqual(Values[4], data.Flag5, "Flag 5 is incorrect");
            Assert.AreEqual(Values[5], data.Flag6, "Flag 6 is incorrect");
            Assert.AreEqual(Values[6], data.Flag7, "Flag 7 is incorrect");
            Assert.AreEqual(Values[7], data.Flag8, "Flag 8 is incorrect");

            for (Int32 I = 0; I < 8; I++) {
                Assert.AreEqual(Values[I], data[I], $"Flag {I} in a loop is incorrect");
            }
        }



        public static Int32 Count(BitFlags8 data) {
            Int32 Count = 0;

            if (data.Flag1) Count++;
            if (data.Flag2) Count++;
            if (data.Flag3) Count++;
            if (data.Flag4) Count++;
            if (data.Flag5) Count++;
            if (data.Flag6) Count++;
            if (data.Flag7) Count++;
            if (data.Flag8) Count++;

            return Count;
        }

        public static Int32 Count(ICollection<Boolean> data) {
            Int32 Count = 0;

            foreach (Boolean Item in data) {
                if (Item) Count++;
            }

            return Count;
        }
    }
}