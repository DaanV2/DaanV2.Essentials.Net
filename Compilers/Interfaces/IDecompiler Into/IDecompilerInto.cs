using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Compilers {
    ///DOLATER <summary> add description for interface: IDecompilerInto</summary>
    public interface IDecompilerInto<TReceiver, ContextType> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <param name="Receiver"></param>
        void DecompileInto(ContextType Context, TReceiver Receiver);
    }
}
