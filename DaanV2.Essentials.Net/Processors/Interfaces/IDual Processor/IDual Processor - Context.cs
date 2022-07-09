/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

namespace DaanV2.Processors {
    /// <summary>The interface responsible for determining how a pre/post processor should work.</summary>
    /// <typeparam name="T">The type to process.</typeparam>
    /// <typeparam name="TypeContext">The type that is used for the context.</typeparam>
    public interface IDualProcessor<T, TypeContext> :
        IPreProcessor<T, TypeContext>,
        IPostProcessor<T, TypeContext> {

    }
}