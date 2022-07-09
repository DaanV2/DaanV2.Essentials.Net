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
        /// <typeparam name="TypeIn"></typeparam>
        /// <typeparam name="TypeStream"></typeparam>
        /// <param name="Serializer"></param>
        /// <param name="O"></param>
        /// <param name="Filepath"></param>
        public static void Serialize<TypeIn, TypeStream>(
            [NotNull] this ISerializer<TypeIn, TypeStream> Serializer,
            [NotNull] TypeIn O,
            [NotNull] String Filepath)
            where TypeStream : Stream {

            Stream stream = new FileStream(Filepath, FileMode.Create, FileAccess.ReadWrite);
            Serializer.Serialize(O, (TypeStream)stream);
            stream.Flush();
            stream.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TypeIn"></typeparam>
        /// <typeparam name="TypeStream"></typeparam>
        /// <typeparam name="TypeContext"></typeparam>
        /// <param name="Serializer"></param>
        /// <param name="O"></param>
        /// <param name="Context"></param>
        /// <param name="Filepath"></param>
        public static void Serialize<TypeIn, TypeStream, TypeContext>(
            [NotNull] this ISerializer<TypeIn, TypeStream, TypeContext> Serializer,
            [NotNull] TypeIn O,
            [NotNull] TypeContext Context,
            [NotNull] String Filepath)
            where TypeStream : Stream {

            Stream stream = new FileStream(Filepath, FileMode.Create, FileAccess.ReadWrite);
            Serializer.Serialize(O, (TypeStream)stream, Context);
            stream.Flush();
            stream.Close();
        }
    }
}