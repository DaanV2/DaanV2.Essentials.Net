using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Processors {
    ///DOLATER <summary> add description for interface: IDualProcessorOut</summary>
    public interface IDualProcessorOut<TIn, TOut> : IPreProcessor<TIn, TOut>, IPostProcessor<TIn, TOut> {
        
    }
}
