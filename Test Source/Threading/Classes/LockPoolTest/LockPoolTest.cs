#pragma warning disable IDE0059 // Unnecessary assignment of a value
using System;
using System.Threading;
using DaanV2.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Threading {
    [TestClass]
    public sealed partial class LockPoolTest {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestIndex() {
            Int32 Count = Environment.ProcessorCount;
            const String Temp = "something";
            var Lock = new LockPool(Count);

            for (Int32 I = 0; I < Count * 2; I++) {
                EventWaitHandle L = Lock.GetHandle(I);
                LockInstance Instance = Lock.GetInstance(I);

                Instance = Lock.GetInstance(Temp);
            }
        }
    }
}

#pragma warning restore IDE0059 // Unnecessary assignment of a value
