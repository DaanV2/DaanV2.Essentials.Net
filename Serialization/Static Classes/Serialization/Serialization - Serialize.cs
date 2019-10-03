/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.


THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS.IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;
using System.IO;

namespace DaanV2.Serialization {
    public static partial class Serialization {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="O"></param>
        /// <param name="FactoryName"></param>
        /// <param name="Filepath"></param>
        public static void Serialize<T>(T O, String FactoryName, String Filepath) {
            ISerializer<T, Stream> Serializer = GetSerializer<T>(FactoryName);
            FileStream Writer = new FileStream(Filepath, FileMode.Create);
            Serializer.Serialize(O, Writer);

            Writer.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="FactoryName"></param>
        /// <param name="Filepath"></param>
        /// <returns></returns>
        public static T Deserialize<T>(String FactoryName, String Filepath) {
            IDeserializer<T, Stream> deserializer = GetDeserializer<T>(FactoryName);
            FileStream Reader = new FileStream(Filepath, FileMode.Open);

            T Out = deserializer.Deserialize(Reader);

            Reader.Close();

            return Out;
        }

    }
}
