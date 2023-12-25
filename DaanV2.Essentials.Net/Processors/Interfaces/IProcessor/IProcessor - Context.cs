
namespace DaanV2.Processors {
    /// <summary>The interface responsible for forming on how an Processor should work with context.</summary>
    public interface IProcessor<T, TypeContext> {
        /// <summary>Processes the specified object with the given context.</summary>
        /// <param name="Process">The object to process.</param>
        /// <param name="Context">The context used to process the given object.</param>
        void Process(T Process, TypeContext Context);
    }
}