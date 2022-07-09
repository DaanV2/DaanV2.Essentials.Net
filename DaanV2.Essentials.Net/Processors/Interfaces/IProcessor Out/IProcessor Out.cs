/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
namespace DaanV2.Processors {
    /// <summary>The interface responsible for processing the given object to the output.</summary>
    public interface IProcessorOut<T, TypeOut> {
        /// <summary>Processes the given object into the outputted type.</summary>
        /// <param name="Process">The object to process.</param>
        /// <returns>Processes the given object into the outputted type.</returns>
        TypeOut Process(T Process);
    }
}