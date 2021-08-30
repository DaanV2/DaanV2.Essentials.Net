/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

namespace DaanV2.Processors {
    /// <summary>The interface responsible for determing how pre processor should work.</summary>
    public interface IPreProcessor<T> {
        /// <summary>Pre processes the given object.</summary>
        /// <param name="Process">The object to preprocess.</param>
        void Preprocess(T Process);
    }
}
