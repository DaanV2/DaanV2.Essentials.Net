using System;
using System.Threading;

namespace DaanV2.Threading {
    public sealed partial class LockInstance {
        /// <summary>The field that stores if this instance has been locked</summary>
        private Boolean _Locked;
        /// <summary>The field that stores the wait handle</summary>
        private EventWaitHandle _Lock;
    }
}
