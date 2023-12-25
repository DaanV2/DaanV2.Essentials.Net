using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DaanV2 {
    public partial class PriorityAttributeComparer : IComparer<Object> {
        /// <summary>Compares two object to each other, retrieves the priority attribute from them.</summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        /// <returns>Compares two object to each other, retrieves the priority attribute from them.</returns>
        public Int32 Compare([NotNull] Object x, [NotNull] Object y) {
            Type Tx = x.GetType();
            Type Ty = y.GetType();

            PriorityAttribute PAx = Tx.GetAttribute<PriorityAttribute>();
            PriorityAttribute PAy = Ty.GetAttribute<PriorityAttribute>();

            return PAx is null || PAy is null ?
                Tx.Name.CompareTo(Ty.Name) :
                PAx.Value.CompareTo(PAy.Value);
        }
    }
}