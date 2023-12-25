using System;
using System.Collections.Generic;
using DaanV2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Net_Core {
    [TestClass]
    public partial class ICopyableTest {
        /// <summary>
        /// 
        ///.</summary>
        [TestMethod]
        public void CopyString() {
            String DataHolder = "I am so piece of text with copyable values";

            String Copy = StringExtension.Copy(DataHolder);

            if (Copy.Length != DataHolder.Length) {
                Assert.Fail("Copy is not the same length as original");
            }

            for (Int32 I = 0; I < DataHolder.Length; I++) {
                if (DataHolder[I] != Copy[I]) {
                    Assert.Fail("Source and copy are not the same");
                }
            }

            if (Object.ReferenceEquals(DataHolder, Copy)) {
                Assert.Fail("Source and copy are the same object");
            }
        }

        /// <summary>
        /// 
        ///.</summary>
        [TestMethod]
        public void CopyStringArrayTest() {
            String[] Values = new String[] { "Something to test", "", "I am a longer piece of text" };
            String[] Copy = Values.Copy();

            if (Copy.Length != Values.Length) {
                Assert.Fail("Copy is not the same length as original");
            }

            String V, C;

            for (Int32 I = 0; I < Values.Length; I++) {
                V = Values[I];
                C = Copy[I];

                if (C.Length != V.Length) {
                    Assert.Fail("Copy is not the same length as original");
                }

                for (Int32 J = 0; J < V.Length; J++) {
                    if (V[J] != C[J]) {
                        Assert.Fail("Source and copy are not the same");
                    }
                }

                if (!String.IsNullOrEmpty(V)) {
                    if (Object.ReferenceEquals(V, C)) {
                        Assert.Fail("Source and copy are the same object");
                    }
                }
            }
        }

        /// <summary>
        /// 
        ///.</summary>
        [TestMethod]
        public void CopyStringListTest() {
            var Values = new List<String> { "Something to test", "", "I am a longer piece of text" };
            List<String> Copy = Values.Copy();

            if (Copy.Count != Values.Count) {
                Assert.Fail("Copy is not the same length as original");
            }

            String V, C;

            for (Int32 I = 0; I < Values.Count; I++) {
                V = Values[I];
                C = Copy[I];

                if (C.Length != V.Length) {
                    Assert.Fail("Copy is not the same length as original");
                }

                for (Int32 J = 0; J < V.Length; J++) {
                    if (V[J] != C[J]) {
                        Assert.Fail("Source and copy are not the same");
                    }
                }

                if (!String.IsNullOrEmpty(V)) {
                    if (Object.ReferenceEquals(V, C)) {
                        Assert.Fail("Source and copy are the same object");
                    }
                }
            }
        }
    }
}