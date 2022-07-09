/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

namespace DaanV2.Processors {
    /// <summary>The interface responsible for determining how a Pre processor with output should work.</summary>
    public interface IPreProcessorOut<TIn, TOut> {
        /// <summary>Pre processes the specified object into the output object.</summary>
        /// <param name="Process">The object to pre processes.</param>
        /// <returns>Pre processes the specified object into the output object.</returns>
        TOut Preprocess(TIn Process);
    }
}