/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace DaanV2.Serialization {
    public static partial class Extension {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TypeOut"></typeparam>
        /// <typeparam name="TypeStream"></typeparam>
        /// <param name="Serializer"></param>
        /// <param name="Filepath"></param>
        /// <returns></returns>
        public static TypeOut Deserialize<TypeOut, TypeStream>(
            [NotNull] this IDeserializer<TypeOut, TypeStream> Serializer,
            [NotNull] String Filepath)
            where TypeStream : Stream {

            Stream stream = new FileStream(Filepath, FileMode.Open, FileAccess.ReadWrite);
            TypeOut Out = Serializer.Deserialize((TypeStream)stream);
            stream.Close();

            return Out;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TypeOut"></typeparam>
        /// <typeparam name="TypeStream"></typeparam>
        /// <typeparam name="TypeContext"></typeparam>
        /// <param name="Serializer"></param>
        /// <param name="Context"></param>
        /// <param name="Filepath"></param>
        /// <returns></returns>
        public static TypeOut Deserialize<TypeOut, TypeStream, TypeContext>(
            [NotNull] this IDeserializer<TypeOut, TypeStream, TypeContext> Serializer,
            [NotNull] TypeContext Context, 
            [NotNull] String Filepath)
            where TypeStream : Stream {

            Stream stream = new FileStream(Filepath, FileMode.Open, FileAccess.ReadWrite);
            TypeOut Out = Serializer.Deserialize((TypeStream)stream, Context);
            stream.Close();

            return Out;
        }
    }
}
