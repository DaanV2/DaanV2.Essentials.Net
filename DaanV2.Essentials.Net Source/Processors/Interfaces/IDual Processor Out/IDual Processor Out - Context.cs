/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

namespace DaanV2.Processors {
    /// <summary>The interface responsible for determining how a pre/post processor should work.</summary>
    /// <typeparam name="TIn">The type to process.</typeparam>
    /// <typeparam name="TOut">The type that gets outputted.</typeparam>
    /// <typeparam name="TypeContext">The context needed to process.</typeparam>
    public interface IDualProcessorOut<TIn, TOut, TypeContext>
        : IPreProcessorOut<TIn, TOut, TypeContext>,
        IPostProcessorOut<TIn, TOut, TypeContext> {

    }
}
