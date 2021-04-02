using System;
using System.Threading;
using System.Threading.Tasks;
using DaanV2.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Threading {
    [TestClass]
    public partial class LockInstanceTest {
        public static EventWaitHandle Auto = new AutoResetEvent(true);

        [TestMethod]
        public void TestDeadLock() {
            var Tasks = new Task[] {
                Task.Run(Test),
                Task.Run(Test)
            };

            Boolean Result = Task.WaitAll(Tasks, 5000);

            if (Result) {

            }
            else {
                Assert.Fail();
            }
        }

        public static void Test() {
            var Instance = LockInstance.Create(Auto);

            Instance.Lock();
            Instance.Lock();

            Thread.Sleep(1000);

            Instance.UnLock();
        }
    }
}
