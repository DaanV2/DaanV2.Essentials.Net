/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

namespace DaanV2.Processors {
    /// <summary>The interface responsible for forming the contract on how Pre processors should work.</summary>
    /// <typeparam name="T">The type of object to pre process.</typeparam>
    /// <typeparam name="TypeContext">The type of object used as context.</typeparam>
    public interface IPreProcessor<T, TypeContext> {
        /// <summary>Pre processes the given object.</summary>
        /// <param name="Process">The object to pre process.</param>
        /// <param name="Context">The context used to pre process.</param>
        void Preprocess(T Process, TypeContext Context);
    }
}