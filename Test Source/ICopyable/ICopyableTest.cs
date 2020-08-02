using System;
using System.Collections.Generic;
using DaanV2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.ICopyable {

    public class CopyableDataClassA : DaanV2.ICopyable<CopyableDataClassA> {
        public String Name { get; set; }

        public CopyableDataClassB Data { get; set; }

        public CopyableDataClassA Copy() {
            return new CopyableDataClassA() {
                Name = this.Name.Copy(),
                Data = this.Data.Copy()
            };
        }
    }

    public class CopyableDataClassB : DaanV2.ICopyable<CopyableDataClassB> {
        public String Name { get; set; }

        public Int32 Test { get; set; }

        public CopyableDataClassB Copy() {
            return new CopyableDataClassB() {
                Name = this.Name.Copy(),
                Test = this.Test
            };
        }
    }

    [TestClass]
    public class ICopyableTest {

        public CopyableDataClassA NewData() {
            return new CopyableDataClassA() {
                Name = "I am class A",
                Data = new CopyableDataClassB() {
                    Name = "I am a child",
                    Test = 1
                }
            };
        }

        public void TestReference(CopyableDataClassA Original, CopyableDataClassA Copy) {
            Assert.IsFalse(Object.ReferenceEquals(Original, Copy), "A copy was not created");
            Assert.IsFalse(Object.ReferenceEquals(Original.Name, Copy.Name), "A copy name was not created");
            Assert.IsFalse(Object.ReferenceEquals(Original.Data, Copy.Data), "A copy data was not created");
            Assert.IsFalse(Object.ReferenceEquals(Original.Data.Name, Copy.Data.Name), "A copy data name was not created");
            Assert.IsFalse(Object.ReferenceEquals(Original.Data.Test, Copy.Data.Test), "A copy data test was not created");
        }


        [TestMethod]
        public void TestSingle() {
            CopyableDataClassA Original = this.NewData();

            CopyableDataClassA Copy = Original.Copy();

            this.TestReference(Original, Copy);

            Copy.Data.Test = 2;
            Copy.Name = "";

            Assert.IsFalse(Copy.Name == Original.Name);
            Assert.IsFalse(Copy.Data.Test == Original.Data.Test);
        }

        [TestMethod]
        public void TestList() {
            List<CopyableDataClassA> Originals = new List<CopyableDataClassA>();

            for (Int32 I = 0; I < 10; I++) {
                Originals.Add(this.NewData());
            }

            List<CopyableDataClassA> Copy = Originals.Copy();

            Assert.IsFalse(Object.ReferenceEquals(Originals, Copy), "A copy was not created");

            Assert.IsTrue(Originals.Count == Copy.Count, "Not the same amount of elements");

            for (Int32 I = 0; I < Originals.Count; I++) {
                this.TestReference(Originals[I], Copy[I]);
            }
        }

        [TestMethod]
        public void TestArray() {
            CopyableDataClassA[] Originals = new CopyableDataClassA[10];

            for (Int32 I = 0; I < 10; I++) {
                Originals[I] = this.NewData();
            }

            CopyableDataClassA[] Copy = Originals.Copy();

            Assert.IsFalse(Object.ReferenceEquals(Originals, Copy), "A copy was not created");

            Assert.IsTrue(Originals.Length == Copy.Length, "Not the same amount of elements");

            for (Int32 I = 0; I < Originals.Length; I++) {
                this.TestReference(Originals[I], Copy[I]);
            }
        }
    }
}
