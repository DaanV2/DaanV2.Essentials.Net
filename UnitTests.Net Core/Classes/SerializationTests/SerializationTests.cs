using System;
using System.Collections.Generic;
using DaanV2.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Net_Core {
    ///DOLATER <summary>add description for class: SerializationTests</summary>
    [TestClass]
    public partial class SerializationTests {
        [TestMethod]
        public void SerializationLoadTest() {
            List<String> Items = Serialization.GetFactoryNames();

            Boolean Json = false, Xml = false;

            foreach (String Item in Items) {
                if (Item == "json") {
                    Json = true;
                }

                if (Item == "xml") {
                    Xml = true;
                }
            }

            Assert.IsFalse(Json, "Json factory not found");
            Assert.IsFalse(Xml, "Xml factory not found");
        }
    }
}
