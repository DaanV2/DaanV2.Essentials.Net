using System.Diagnostics.CodeAnalysis;

namespace DaanV2.Serialization {
    /// <summary>The interface that is responsible for forming the contract on how serializers should work.</summary>
    /// <typeparam name="TypeIn">The type that is being serializied.</typeparam>
    /// <typeparam name="TypeStream">The stream type used to write the given type.</typeparam>
    /// <typeparam name="TypeContext">The context needed to serialize the given type.</typeparam>
    public interface ISerializer<TypeIn, TypeStream, TypeContext> {

        /// <summary>Serializes the given object into the given stream along with the context needed to serialize.</summary>
        /// <param name="O">The object to serialize.</param>
        /// <param name="Writer">The stream to write the given object into.</param>
        /// <param name="Context">The context that is needed to the serialize the given object.</param>
        void Serialize([NotNull] TypeIn O, [NotNull] TypeStream Writer, [NotNull] TypeContext Context);
    }
}