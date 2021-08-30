using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DaanV2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Threading {
    [TestClass]
    public partial class ParralelTest {
        [TestMethod]
        public void ForEachTest() {
            ParralelTestDataItem[] Data = this._Data.Copy();

            this.TestTasks(DaanV2.Threading.Parallel.ForEach(Data, new Action<ParralelTestDataItem>(this.Operation)));
            this.TestTasks(DaanV2.Threading.Parallel.ForEach(Data, new Action<ParralelTestDataItem>(this.Operation), 2));
            this.TestTasks(DaanV2.Threading.Parallel.ForEach(Data, new Action<ParralelTestDataItem>(this.Operation), 4));
            this.TestTasks(DaanV2.Threading.Parallel.ForEach(Data, new Action<ParralelTestDataItem>(this.Operation), 8));
        }

        [TestMethod]
        public void ForEach2Test() {
            ParralelTestDataItem[] Data = this._Data.Copy();
            (Int32 Substract, Int32 Multiple) DataContext = (5, 9);

            this.TestTasks(DaanV2.Threading.Parallel.ForEach(Data, 
                new Action<ParralelTestDataItem, (Int32 Substract, Int32 Multiple)>(this.Operation), DataContext));
            this.TestTasks(DaanV2.Threading.Parallel.ForEach(Data, 
                new Action<ParralelTestDataItem, (Int32 Substract, Int32 Multiple)>(this.Operation), DataContext, 2));
            this.TestTasks(DaanV2.Threading.Parallel.ForEach(Data, 
                new Action<ParralelTestDataItem, (Int32 Substract, Int32 Multiple)>(this.Operation), DataContext, 4));
            this.TestTasks(DaanV2.Threading.Parallel.ForEach(Data, 
                new Action<ParralelTestDataItem, (Int32 Substract, Int32 Multiple)>(this.Operation), DataContext, 8));
        }

        [TestMethod]
        public void ForEach3Test() {
            List<ParralelTestDataItem> Data = new List<ParralelTestDataItem>();
            Data.AddRange(this._Data.Copy());

            this.TestTasks(DaanV2.Threading.Parallel.ForEach(Data, new Action<ParralelTestDataItem>(this.Operation)));
        }

        [TestMethod]
        public void ForEach4Test() {
            List<ParralelTestDataItem> Data = new List<ParralelTestDataItem>();
            Data.AddRange(this._Data.Copy());
            (Int32 Substract, Int32 Multiple) DataContext = (5, 9);

            this.TestTasks(DaanV2.Threading.Parallel.ForEach(
                Data,
                new Action<ParralelTestDataItem, (Int32 Substract, Int32 Multiple)>(this.Operation), DataContext));
        }

        public void Operation(ParralelTestDataItem X) {
            X.Calculated = X.A + X.B;
        }

        public void Operation(ParralelTestDataItem X, Int32 Extra) {
            X.Calculated = X.A + X.B - Extra;
        }

        public void Operation(ParralelTestDataItem X, (Int32 Substract, Int32 Multiple) Extra) {
            X.Calculated = ((X.A + X.B) - Extra.Substract) * Extra.Multiple;
        }


        public void TestTasks(Task[] Tasks) {
            Task.WaitAll(Tasks);

            for (Int32 I = 0; I < Tasks.Length; I++) {
                if (Tasks[I].Exception != null) {
                    Assert.Fail(Tasks[I].Exception.Message);
                }
            }
        }
    }
}
