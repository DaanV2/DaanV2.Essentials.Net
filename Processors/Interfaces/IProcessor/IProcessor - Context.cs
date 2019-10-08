using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Processors {
    ///DOLATER <summary> add description for interface: IProcessor</summary>
    public interface IProcessor<T, TypeContext> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Process"></param>
        /// <param name="Context"></param>
        void Process(T Process, TypeContext Context);
    }
}
