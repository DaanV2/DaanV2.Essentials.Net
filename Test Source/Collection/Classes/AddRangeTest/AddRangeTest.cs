﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using DaanV2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Collection {
    ///DOLATER <summary>add description for class: AddRangeTest</summary>
    [TestClass]
    public sealed partial class AddRangeTest {

        static public List<Int32> Source1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static public List<Int32> Source2 = new List<int>() { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

        [TestMethod]
        public void AddRangeTest1() {
            List<Int32> Temp = new List<int>();

            Temp.AddRange(Source1, 0, 5);
            Temp.AddRange(Source2, 2, 5);

            for (Int32 I = 0; I < 5; I++) {
                Assert.IsTrue(Temp[I] == Source1[I]);
            }

            for (Int32 I = 0; I < 5; I++) {
                Assert.IsTrue(Temp[I + 5] == Source2[I + 2]);
            }

        }
    }
}
