using System;
using DaanV2;

namespace UnitTests.Threading {


    public partial class ParralelTest {

        private ParralelTestDataItem[] _Data;

        public class ParralelTestDataItem : ICopyable<ParralelTestDataItem> {

            public ParralelTestDataItem(Int32 A, Int32 B, Int32 C) {
                this.A = A;
                this.B = B;
                this.Calculated = C;
            }

            public ParralelTestDataItem(Random C) {
                this.A = C.Next(Int32.MinValue, Int32.MaxValue);
                this.B = C.Next(Int32.MinValue, Int32.MaxValue);
                this.Calculated = 0;
            }

            public Int32 A { get; set; }

            public Int32 B { get; set; }

            public Int32 Calculated { get; set; }

            public ParralelTestDataItem Copy() {
                return new ParralelTestDataItem(this.A, this.B, this.Calculated);
            }
        }
    }
}
