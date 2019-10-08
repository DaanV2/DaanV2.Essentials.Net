using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Processors {
    ///DOLATER <summary> add description for interface: IPreProcessor</summary>
    public interface IPreProcessor<T, TypeContext> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Process"></param>
        /// <param name="Context"></param>
        void Preprocess(T Process, TypeContext Context);
    }
}
