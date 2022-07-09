/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
namespace DaanV2.Processors {
    /// <summary>The interface responsible for Processors that have an output.</summary>
    public interface IProcessorOut<T, TypeOut, TypeContext> {
        /// <summary>Processes the given object into the specified type.</summary>
        /// <param name="Process">The object to process.</param>
        /// <param name="Context">The context type needed to process.</param>
        TypeOut Process(T Process, TypeContext Context);
    }
}