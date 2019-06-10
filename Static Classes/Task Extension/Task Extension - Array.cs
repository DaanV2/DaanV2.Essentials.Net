using System.Threading.Tasks;

namespace DaanV2 {
    public static partial class TaskExtension {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Tasks"></param>
		public static void WaitAll(this Task[] Tasks) {
            Task.WaitAll(Tasks);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Tasks"></param>
        public static void WaitAny(this Task[] Tasks) {
            Task.WaitAny(Tasks);
        }
    }
}
