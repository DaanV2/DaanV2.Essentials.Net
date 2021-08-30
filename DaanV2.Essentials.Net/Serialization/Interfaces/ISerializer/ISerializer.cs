/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

using System.Diagnostics.CodeAnalysis;

namespace DaanV2.Serialization {
    /// <summary>The interface that is responsible for forming the contract on how serializers should work.</summary>
    /// <typeparam name="TypeIn">The input type.</typeparam>
    /// <typeparam name="TypeStream">The stream type.</typeparam>
    public interface ISerializer<TypeIn, TypeStream> {

        /// <summary>Serializes the given object into the given stream.</summary>
        /// <param name="O">The object to serialize.</param>
        /// <param name="Writer">The stream to write the object into.</param>
        void Serialize([NotNull] TypeIn O, [NotNull] TypeStream Writer);
    }
}
