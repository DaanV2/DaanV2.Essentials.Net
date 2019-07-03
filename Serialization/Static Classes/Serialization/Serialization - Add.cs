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
using System.Reflection;

namespace DaanV2.Serialization {
    public static partial class Serialization {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Factory"></param>
        public static void Add(ISerializerFactory<Stream> Factory) {
            Serialization.Factories[Factory.Name] = Factory;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="assembly"></param>
        public static void Add(Assembly assembly) {
            Type[] Types = assembly.GetTypes();
            Int32 Max = Types.Length;
            Type T;
            DaanV2.Serialization.SerializerAttribute SAttribute;
            DaanV2.Serialization.DeserializerAttribute DAttribute;

            for (Int32 I = 0; I < Max; I++) {
                T = Types[I];
                if (T.ContainsInterface(typeof(ISerializerFactory<Stream>))) { 

                }
                else {
                    SAttribute = T.GetAttribute<DaanV2.Serialization.SerializerAttribute>();
                    DAttribute = T.GetAttribute< DaanV2.Serialization.DeserializerAttribute >();

                    if (SAttribute != null) Serialization.Get(SAttribute.FactoryName).SetSerializeType(T);
                    if (DAttribute != null) Serialization.Get(DAttribute.FactoryName).SetSerializeType(T);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        private static ISerializerFactory<Stream> Get(String Name) {
            if (!Serialization.Factories.ContainsKey(Name))
                Serialization.Factories[Name] = new SerializationFactory();

            return Serialization.Factories[Name];
        }
    }
}
