using System;
using System.Collections.Generic;
using DaanV2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Net_Core {
    [TestClass]
    public partial class IReplaceable {
        [TestMethod]
        public void ListString() {
            var Values = new List<String> { "Example1", "Example2", "Example3", "Example4" };

            this.TestList(Values, "Example", "NewExample");
            this.TestList(Values, "Something", "AbsolutlyNothing");
        }

        private void TestList(List<String> Values, String Old, String New) {
            List<String> Temp = Values.Copy();
            Temp.Replace(Old, New);

            if (Values.Count != Temp.Count) {
                Assert.Fail("Count amount seems to change");
            }

            for (Int32 I = 0; I < Values.Count; I++) {
                if (Values[I].Replace(Old, New) != Temp[I]) {
                    Assert.Fail("Replacement failed");
                }
            }
        }
    }
}