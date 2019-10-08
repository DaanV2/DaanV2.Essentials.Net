using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Processors {
    ///DOLATER <summary> add description for interface: IPreProcessor</summary>
    public interface IPreProcessorOut<TIn, TOut, TypeContext> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Process"></param>
        /// <param name="Context"></param>
        TOut Preprocess(TIn Process, TypeContext Context);
    }
}
