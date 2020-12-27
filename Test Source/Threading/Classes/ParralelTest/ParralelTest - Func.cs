using System;
using DaanV2.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Threading {


    public partial class ParralelTest {

        [TestMethod]
        public void TestFuncParralel() {
            var R = new Random();
            Double[] Data = new Double[100];

            for (Int32 I = 0; I < Data.Length; I++) {
                Data[I] = R.NextDouble();
            }

            FuncResult<String> Out = Parallel.Func.ForEach(Data, ParralelTest.ConvertItem);

            Out.WaitAll();

            if (Out.Output.Length != Data.Length) {
                Assert.Fail("Output should be the same length as input");
            }

            for (Int32 I = 0; I < Data.Length; I++) {
                Assert.IsTrue(ConvertItem(Data[I]) == Out.Output[I], $"Item did not convert well: {Data[I]}=={Out.Output[I]}");
            }
        }

        public static String ConvertItem(Double Item) {
            return Item.ToString();
        }
    }
}
