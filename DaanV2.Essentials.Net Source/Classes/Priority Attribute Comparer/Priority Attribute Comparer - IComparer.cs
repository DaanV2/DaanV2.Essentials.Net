using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2 {
    public partial class PriorityAttributeComparer : IComparer<Object> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Int32 Compare(Object x, Object y) {
            Type Tx = x.GetType();
            Type Ty = y.GetType();

            PriorityAttribute PAx = Tx.GetAttribute<PriorityAttribute>();
            PriorityAttribute PAy = Ty.GetAttribute<PriorityAttribute>();

            return PAx == null || PAy == null ? 
                Tx.Name.CompareTo(Ty.Name) : 
                PAx.Value.CompareTo(PAy.Value);
        }
    }
}
