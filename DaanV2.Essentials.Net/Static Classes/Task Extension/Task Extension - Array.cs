/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System.Threading.Tasks;

namespace DaanV2 {
    /// <summary>The static class thats extends op on existing task code.</summary>
    public static partial class TaskExtension {

        /// <summary>Waits for all tasks to finish.</summary>
        /// <param name="Tasks">The array of tasks to wait for.</param>
		public static void WaitAll(this Task[] Tasks) {
            Task.WaitAll(Tasks);
        }

        /// <summary>Waits for any of the tasks to finish.</summary>
        /// <param name="Tasks">The array of tasks to wait for.</param>
        public static void WaitAny(this Task[] Tasks) {
            Task.WaitAny(Tasks);
        }
    }
}