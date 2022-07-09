/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

namespace DaanV2.Processors {
    /// <summary>The interface that is responsible for determining how a processor should work.</summary>
    public interface IProcessor<T> {
        /// <summary>Processes the specified object.</summary>
        /// <param name="Process">The object to process.</param>
        void Process(T Process);
    }
}