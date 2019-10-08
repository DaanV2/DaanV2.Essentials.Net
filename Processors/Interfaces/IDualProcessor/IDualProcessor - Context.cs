using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Processors {
    ///DOLATER <summary> add description for interface: IDualProcessor</summary>
    public interface IDualProcessor<T, TypeContext> : IPreProcessor<T, TypeContext>, IPostProcessor<T, TypeContext> {
        
    }
}
