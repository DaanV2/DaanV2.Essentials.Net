using DaanV2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests {

    public enum TestEnum {
        Value1,
        Value2,
        Value3,
        Value4
    }

    [TestClass]
    public partial class EnumeratorExtensionTest {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void ReplaceTest() {
            TestEnum Temp = TestEnum.Value1;

            Temp = Temp.Replace("Value1", "Value2");

            Assert.IsTrue(Temp == TestEnum.Value2, "Replace didn't work");

            Temp = Temp.Replace("Value3", "Value4");

            Assert.IsTrue(Temp == TestEnum.Value2, "Replace modified values that shouldn't have");
        }
    }
}