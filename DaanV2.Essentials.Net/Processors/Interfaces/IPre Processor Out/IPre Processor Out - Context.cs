
namespace DaanV2.Processors {
    /// <summary>The interface responsible for detereming how a pre processor should work.</summary>
    public interface IPreProcessorOut<TIn, TOut, TypeContext> {
        /// <summary>Pre processes the given object into the specified type.</summary>
        /// <param name="Process">The object to process.</param>
        /// <param name="Context">The context needed to process this object.</param>
        TOut Preprocess(TIn Process, TypeContext Context);
    }
}