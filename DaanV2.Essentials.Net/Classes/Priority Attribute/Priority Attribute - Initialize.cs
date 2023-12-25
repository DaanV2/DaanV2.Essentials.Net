using System;
using System.Runtime.Serialization;

namespace DaanV2 {
    /// <summary> add description for class: PriorityAttribute.</summary>
	[Serializable, DataContract]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public partial class PriorityAttribute : Attribute {
        /// <summary>Creates a new instance of <see cref="PriorityAttribute"/>.</summary>
        public PriorityAttribute() {
            this.Value = 0;
        }

        /// <summary>Creates a new instance of <see cref="PriorityAttribute"/>.</summary>
        /// <param name="Value">The value to assign.</param>
        public PriorityAttribute(Int32 Value) {
            this.Value = Value;
        }
    }
}