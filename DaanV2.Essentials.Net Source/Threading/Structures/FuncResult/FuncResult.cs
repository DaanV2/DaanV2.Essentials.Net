using System.Threading.Tasks;

namespace DaanV2.Threading {
    ///DOLATER <summary>add description for struct: FuncResult</summary>
    public readonly partial struct FuncResult<U> {
        /// <summary>Creates a new instance of <see cref="FuncResult"/></summary>
        /// <param name="tasks"></param>
        /// <param name="output"></param>
        public FuncResult(Task[] tasks, U[] output) {
            this.Tasks = tasks;
            this.Output = output;
        }

        public readonly Task[] Tasks;
        public readonly U[] Output;        
    }
}
