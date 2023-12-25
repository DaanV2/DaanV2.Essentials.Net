using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace DaanV2.Serialization {
    public static partial class Serialization {
        /// <summary>Serializes the given object into the specified file using the specified factory.</summary>
        /// <param name="O">The object to serialization.</param>
        /// <param name="FactoryName">The name of the factory, <see cref="Serialization.GetFactoryNames"/>.</param>
        /// <param name="Filepath">The file to write.</param>
        public static void Serialize<T>([NotNull] T O, [NotNull] String FactoryName, [NotNull] String Filepath) {
            var Writer = new FileStream(Filepath, FileMode.Create);
            Serialize(O, FactoryName, Writer);
            Writer.Close();
        }

        /// <summary>Serializes the given object into the specified file using the specified factory.</summary>
        /// <param name="O">The object to serialization.</param>
        /// <param name="FactoryName">The name of the factory, <see cref="Serialization.GetFactoryNames"/>.</param>
        /// <param name="stream">The stream to write to.</param>
        public static void Serialize<T>([NotNull] T O, [NotNull] String FactoryName, [NotNull] Stream stream) {
            ISerializer<T, Stream> Serializer = GetSerializer<T>(FactoryName);
            Serializer.Serialize(O, stream);
        }

        /// <summary>Deserializes the given file into the specified object using the specified factory.</summary>
        /// <typeparam name="T">The object to return to.</typeparam>
        /// <param name="FactoryName">The name of the factory, <see cref="Serialization.GetFactoryNames"/>.</param>
        /// <param name="Filepath">The file to read from.</param>
        /// <returns>Deserializes the given file into the specified object using the specified factory.</returns>
        public static T Deserialize<T>([NotNull] String FactoryName, [NotNull] String Filepath) {
            var Reader = new FileStream(Filepath, FileMode.Open);
            T Out = Deserialize<T>(FactoryName, Reader);
            Reader.Close();

            return Out;
        }

        /// <summary>Deserializes the given file into the specified object using the specified factory.</summary>
        /// <typeparam name="T">The object to return to.</typeparam>
        /// <param name="FactoryName">The name of the factory, <see cref="Serialization.GetFactoryNames"/>.</param>
        /// <param name="stream">The stream to read from.</param>
        /// <returns>Deserializes the given file into the specified object using the specified factory.</returns>
        public static T Deserialize<T>([NotNull] String FactoryName, [NotNull] Stream stream) {
            IDeserializer<T, Stream> deserializer = GetDeserializer<T>(FactoryName);
            return deserializer.Deserialize(stream);
        }

    }
}