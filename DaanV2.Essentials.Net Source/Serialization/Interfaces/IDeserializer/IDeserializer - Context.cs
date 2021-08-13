/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

namespace DaanV2.Serialization {
    /// <summary>The interface that is responsible for forming the contract on how Deserializer should work.</summary>
    /// <typeparam name="TypeOut">The type to be returned after deserializing.</typeparam>
    /// <typeparam name="TypeStream">The type of the stream to be used.</typeparam>
    /// <typeparam name="TypeContext">The context needed for deserializing.</typeparam>
    public interface IDeserializer<TypeOut, TypeStream, TypeContext> {

        /// <summary>Deserializer the given stream into the specified type.</summary>
        /// <param name="Reader">The stream to read from.</param>
        /// <param name="Context">The context needed to read the stream.</param>
        /// <returns>Deserializer the given stream into the specified type.</returns>
        TypeOut Deserialize(TypeStream Reader, TypeContext Context);
    }
}
