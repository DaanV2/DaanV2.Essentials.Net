
namespace DaanV2.Processors {
    /// <summary>The interface responsible for detereming how a post processor should work.</summary>
    public interface IPostProcessorOut<TIn, TOut> {
        /// <summary>Post processes the given object.</summary>
        /// <param name="Process">The object to process.</param>
        TOut Postprocess(TIn Process);
    }
}