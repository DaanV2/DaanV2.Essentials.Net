/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

namespace DaanV2.Processors {
    /// <summary>The interface responsible for detereming how a post processor should work.</summary>
    public interface IPostProcessor<T, TypeContext> {
        /// <summary>Post processes the given object with the given context.</summary>
        /// <param name="Process">The object to process.</param>
        /// <param name="Context">The context needed to process.</param>
        void Postprocess(T Process, TypeContext Context);
    }
}