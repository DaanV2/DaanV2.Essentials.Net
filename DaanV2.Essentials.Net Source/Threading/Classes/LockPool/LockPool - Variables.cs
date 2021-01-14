using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DaanV2.Threading {
    public sealed partial class LockPool {
        /// <summary></summary>
        private EventWaitHandle[] _Locks;
       
        /// <summary>
        /// 
        /// </summary>
        private Int32 _Count;
    }
}
