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

        public static CopyableDataClassA NewData() {
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

            //Result is always false
            //Assert.IsFalse(Object.ReferenceEquals(Original.Original.Test, Copy.Original.Test), "A copy data test was not created");
        }


        [TestMethod]
        public void TestSingle() {

/* Unmerged change from project 'UnitTests (net6.0)'
Before:
            CopyableDataClassA Original = this.NewData();
After:
            CopyableDataClassA Original = ICopyableTest.NewData();
*/

/* Unmerged change from project 'UnitTests (net8.0)'
Before:
            CopyableDataClassA Original = this.NewData();
After:
            CopyableDataClassA Original = ICopyableTest.NewData();
*/
            CopyableDataClassA Original = NewData();

            CopyableDataClassA Copy = Original.Copy();

            this.TestReference(Original, Copy);

            Copy.Data.Test = 2;
            Copy.Name = "";

            Assert.IsFalse(Copy.Name == Original.Name);
            Assert.IsFalse(Copy.Data.Test == Original.Data.Test);
        }

        [TestMethod]
        public void TestList() {
            var Originals = new List<CopyableDataClassA>();

            for (Int32 I = 0; I < 10; I++) {

/* Unmerged change from project 'UnitTests (net6.0)'
Before:
                Originals.Add(this.NewData());
After:
                Originals.Add(ICopyableTest.NewData());
*/

/* Unmerged change from project 'UnitTests (net8.0)'
Before:
                Originals.Add(this.NewData());
After:
                Originals.Add(ICopyableTest.NewData());
*/
                Originals.Add(NewData());
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
            var Originals = new CopyableDataClassA[10];

            for (Int32 I = 0; I < 10; I++) {

/* Unmerged change from project 'UnitTests (net6.0)'
Before:
                Originals[I] = this.NewData();
After:
                Originals[I] = ICopyableTest.NewData();
*/

/* Unmerged change from project 'UnitTests (net8.0)'
Before:
                Originals[I] = this.NewData();
After:
                Originals[I] = ICopyableTest.NewData();
*/
                Originals[I] = NewData();
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