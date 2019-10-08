using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Processors {
    ///DOLATER <summary> add description for interface: IPreProcessor</summary>
    public interface IPreProcessorOut<TIn, TOut> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Process"></param>
        TOut Preprocess(TIn Process);
    }
}
