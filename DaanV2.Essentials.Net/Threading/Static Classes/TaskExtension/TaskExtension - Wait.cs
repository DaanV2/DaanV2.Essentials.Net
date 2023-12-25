
using System.Threading.Tasks;

namespace DaanV2.Threading {
    ///DOLATER <summary>add description for class: TaskExtension</summary>
    public static partial class TaskExtension {
        /// <summary>Waits for all of the provided <see cref="Task"/> objects to complete execution.</summary>
        /// <param name="Tasks">An array of <see cref="Task"/> instances on which to wait.</param>
        public static void WaitAll(this Task[] Tasks) {
            Task.WaitAll(Tasks);
        }

        /// <summary>Waits for any of the provided System.Threading.Tasks.Task objects to complete execution.</summary>
        /// <param name="Tasks">An array of <see cref="Task"/> instances on which to wait.</param>
        public static void WaitAny(this Task[] Tasks) {
            Task.WaitAny(Tasks);
        }
    }
}