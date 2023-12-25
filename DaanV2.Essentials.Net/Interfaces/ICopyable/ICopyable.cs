
namespace DaanV2 {
    /// <summary>The interface responsible for forming on how an object needs to be copied.</summary>
    public interface ICopyable<T> {
        /// <summary>Return a new instance of this object.</summary>
        /// <returns>Return a new instance of this object.</returns>
        T Copy();
    }
}