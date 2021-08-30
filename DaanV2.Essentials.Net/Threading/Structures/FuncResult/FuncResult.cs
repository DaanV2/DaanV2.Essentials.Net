using System.Threading.Tasks;

namespace DaanV2.Threading {
    /// <summary>The struct that represents the output of a parralel <see cref="System.Func{T, TResult}"/> process</summary>
    /// <typeparam name="U">The list of items to be returned</typeparam>
    public readonly partial struct FuncResult<U> {
        /// <summary>Creates a new instance of <see cref="FuncResult{U}"/></summary>
        /// <param name="tasks"></param>
        /// <param name="output"></param>
        public FuncResult(Task[] tasks, U[] output) {
            this.Tasks = tasks;
            this.Output = output;
        }

        /// <summary>The array of <see cref="Task"/> that is returned so that the programmer can wait for this tasks to be completed</summary>
        public readonly Task[] Tasks;

        /// <summary>The array of output items to be returned, must be the same size as the inputted collection</summary>
        public readonly U[] Output;        
    }
}
