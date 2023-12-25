using System.Diagnostics.CodeAnalysis;

namespace DaanV2.Serialization {
    /// <summary>The interface that is responsible for forming the contract on how Deserializer should work.</summary>
    /// <typeparam name="TypeOut">The type that needs to be returned after deserializing.</typeparam>
    /// <typeparam name="TypeStream">The type that is used as the data stream.</typeparam>
    public interface IDeserializer<TypeOut, TypeStream> {
        /// <summary>Deserialize the given stream into <typeparamref name="TypeOut"/>.</summary>
        /// <param name="Reader">The stream to read from.</param>
        /// <returns>Deserialize the given stream into the specified <typeparamref name="TypeOut"/>.</returns>
        [return: MaybeNull]
        TypeOut Deserialize([NotNull] TypeStream Reader);
    }
}