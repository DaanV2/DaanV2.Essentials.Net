using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscherProjects.Essentials.Net.Compilers {
    ///DOLATER <summary> add description for interface: IDecompilerInto</summary>
    public interface IDecompilerInto<TOut, ContextType> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <param name="Receiver"></param>
        void DecompileInto(ContextType Context, TOut Receiver);
    }
}
