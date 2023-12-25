
namespace DaanV2.Processors {
    /// <summary>The interface responsible for determining how a pre/post processor should work.</summary>
    /// <typeparam name="TIn">The type to process.</typeparam>
    /// <typeparam name="TOut">The type that gets outputted.</typeparam>
    public interface IDualProcessorOut<TIn, TOut> :
        IPreProcessorOut<TIn, TOut>,
        IPostProcessorOut<TIn, TOut> {

    }
}