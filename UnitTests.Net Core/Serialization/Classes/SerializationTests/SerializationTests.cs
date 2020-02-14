using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Serialization {

    [DataContract, Serializable]
    public class SerializationClassTest {
        /// <summary>
        /// 
        ///.</summary>
        [DataMember]
        public String Text { get; set; }
    }

    [TestClass]
    public partial class SerializationTests {
        [TestMethod]
        public void SerializationLoadTest() {
            List<String> Items = DaanV2.Serialization.Serialization.GetFactoryNames();

            Boolean Json = false, Xml = false, Bin = false;

            foreach (String Item in Items) {
                if (Item == "json") {
                    Json = true;
                }

                if (Item == "xml") {
                    Xml = true;
                }

                if (Item == "binary") {
                    Bin = true;
                }
            }

            Assert.IsFalse(Json, "Json factory not found");
            Assert.IsFalse(Xml, "Xml factory not found");
            Assert.IsFalse(Bin, "Binary factory not found");
        }

        [TestMethod]
        public void XmlTest() {
            TestSerialization("xml");
        }

        [TestMethod]
        public void JsonTest() {
            TestSerialization("json");
        }

        [TestMethod]
        public void BinaryTest() {
            TestSerialization("binary");
        }

        private void TestSerialization(String FactoryName) {
            MemoryStream Stream = new MemoryStream();
            SerializationClassTest SCT = new SerializationClassTest() {
                Text = $"This is a test text for {FactoryName}"
            };

            DaanV2.Serialization.Serialization.Serialize(SCT, FactoryName, Stream);
            Stream.Position = 0;
            SerializationClassTest Copy = DaanV2.Serialization.Serialization.Deserialize<SerializationClassTest>(FactoryName, Stream);

            Assert.IsTrue(Copy.Text == SCT.Text, $"{FactoryName} serialization failed");
        }
    }
}
