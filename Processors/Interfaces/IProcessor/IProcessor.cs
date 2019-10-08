using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Processors {
    ///DOLATER <summary> add description for interface: IProcessor</summary>
    public interface IProcessor<T> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Process"></param>
        void Process(T Process);
    }
}
