using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2 {
    ///DOLATER <summary> add description for class: PriorityAttribute</summary>
	[Serializable, DataContract]
    public partial class PriorityAttribute : Attribute {
        /// <summary>Creates a new instance of <see cref="PriorityAttribute"/></summary>
        public PriorityAttribute() {
            this.Value = 0;
        }

        /// <summary>Creates a new instance of <see cref="PriorityAttribute"/></summary>
        /// <param name="Value">The value to assign</param>
        public PriorityAttribute(Int32 Value) {
            this.Value = Value;
        }
    }
}
