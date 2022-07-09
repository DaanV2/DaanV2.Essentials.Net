/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

namespace DaanV2.Processors {
    /// <summary>The interface responsible for determining how a pre/post processor should work.</summary>
    /// <typeparam name="T">The type to process.</typeparam>
    public interface IDualProcessor<T> :
        IPreProcessor<T>,
        IPostProcessor<T> {

    }
}