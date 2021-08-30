using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace UnitTests.Serialization {

    [DataContract, Serializable]
    public class SerializationClassTest {
        /// <summary>
        /// 
        ///.</summary>
        [DataMember, System.Text.Json.JsonProperty("text")]
        public String Text { get; set; }
    }

    [DataContract, Serializable]
    public struct SerializationStructTest {
        /// <summary>
        /// 
        ///.</summary>
        [DataMember, System.Text.Json.JsonProperty("text")]
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
        public void ClassXmlTest() {
            TestClassSerialization("xml");
        }

        [TestMethod]
        public void ClassJsonTest() {
            TestClassSerialization("json");
        }

        [TestMethod]
        public void StructXmlTest() {
            TestStructSerialization("xml");
        }

        [TestMethod]
        public void StructJsonTest() {
            TestStructSerialization("json");
        }

        //Binary has been removed for .net 5.0
        private static void TestClassSerialization(String FactoryName) {
            var Stream = new MemoryStream();
            var SCT = new SerializationClassTest() {
                Text = $"This is a test text for {FactoryName}"
            };

            DaanV2.Serialization.Serialization.Serialize(SCT, FactoryName, Stream);
            Stream.Position = 0;
            SerializationClassTest Copy = DaanV2.Serialization.Serialization.Deserialize<SerializationClassTest>(FactoryName, Stream);

            Assert.IsTrue(Copy.Text == SCT.Text, $"{FactoryName} serialization failed");
        }

        //Binary has been removed for .net 5.0
        private static void TestStructSerialization(String FactoryName) {
            var Stream = new MemoryStream();
            var SCT = new SerializationStructTest() {
                Text = $"This is a test text for {FactoryName}"
            };

            DaanV2.Serialization.Serialization.Serialize(SCT, FactoryName, Stream);
            Stream.Position = 0;
            SerializationClassTest Copy = DaanV2.Serialization.Serialization.Deserialize<SerializationClassTest>(FactoryName, Stream);

            Assert.IsTrue(Copy.Text == SCT.Text, $"{FactoryName} serialization failed");
        }
    }
}
