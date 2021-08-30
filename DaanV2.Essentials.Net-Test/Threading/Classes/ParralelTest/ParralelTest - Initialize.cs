using System;

namespace UnitTests.Threading {
    public partial class ParralelTest {
        public ParralelTest() {
            this._Data = new ParralelTestDataItem[1000];

            Random C = new Random();
            for (Int32 I = 0; I < this._Data.Length; I++) {
                this._Data[I] = new ParralelTestDataItem(C);
            }
        }
    }
}
