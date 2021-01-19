using System;
using System.IO;

namespace DaanV2.Serialization {

    public static partial class Extension {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TypeIn"></typeparam>
        /// <typeparam name="TypeStream"></typeparam>
        /// <param name="Serializer"></param>
        public static void Serialize<TypeIn, TypeStream>(this ISerializer<TypeIn, TypeStream> Serializer, TypeIn O, String Filepath)
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
        /// <param name="Serializer"></param>
        public static void Serialize<TypeIn, TypeStream, TypeContext>(this ISerializer<TypeIn, TypeStream, TypeContext> Serializer, TypeIn O, TypeContext Context, String Filepath)
            where TypeStream : Stream {

            Stream stream = new FileStream(Filepath, FileMode.Create, FileAccess.ReadWrite);
            Serializer.Serialize(O, (TypeStream)stream, Context);
            stream.Flush();
            stream.Close();
        }
    }
}
