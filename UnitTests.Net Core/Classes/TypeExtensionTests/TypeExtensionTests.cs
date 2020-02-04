using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Net_Core {
    public interface ITestTemp { }

    public interface IShouldNotError : ITestTemp { }

    public class RandomTestClass : ITestTemp { }

    ///DOLATER <summary>add description for class: TypeExtensionTests</summary>
    [TestClass]
    public partial class TypeExtensionTests {
        [TestMethod]
        public void GetTypeWith() {
            List<ITestTemp> Items = DaanV2.TypeExtension.GetObjectsWhichImplements<ITestTemp>();
        }
    }
}
