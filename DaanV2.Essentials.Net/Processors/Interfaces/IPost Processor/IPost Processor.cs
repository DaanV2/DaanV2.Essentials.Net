
namespace DaanV2.Processors {

    /// <summary>The interface responsible for determining how post processors should work.</summary>
    public interface IPostProcessor<T> {

        /// <summary>Post processes the given object.</summary>
        /// <param name="Process">The object to process.</param>
        void Postprocess(T Process);
    }
}