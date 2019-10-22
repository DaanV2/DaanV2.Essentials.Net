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

        /// <summary>Add the given factory into the internal list</summary>
        /// <param name="Factory">The factory to add</param>
        public static void Add(ISerializerFactory<Stream> Factory) {
            Serialization._Factories[Factory.Name] = Factory;
        }

        /// <summary>Add the contents of a assembly to the internal list of factories</summary>
        /// <param name="assembly">FILL_ME_IN</param>
        public static void Add(Assembly assembly) {
            Type T;
            SerializerAttribute SAttribute;
            DeserializerAttribute DAttribute;
            Type[] Types = assembly.GetTypes();
            Int32 Max = Types.Length;

            //Loop through all types
            for (Int32 I = 0; I < Max; I++) {
                T = Types[I];

                //Does the type implement ISerializerFactory?
                if (T.ContainsInterface(typeof(ISerializerFactory<Stream>))) {
                    //Create factory
                    ISerializerFactory<Stream> Temp = (ISerializerFactory<Stream>)Activator.CreateInstance(T);

                    //If an older factory exists
                    if (Serialization._Factories.ContainsKey(Temp.Name)) {
                        //Transfer info
                        ISerializerFactory<Stream> Old = Serialization._Factories[Temp.Name];
                        Temp.SetDeserializeType(Old.GetDeserializeType());
                        Temp.SetSerializeType(Old.GetSerializeType());
                    }

                    //Add factory to list
                    Serialization._Factories[Temp.Name] = Temp;
                }

                //Grab the attributes
                SAttribute = T.GetAttribute<SerializerAttribute>();
                DAttribute = T.GetAttribute<DeserializerAttribute>();

                //If null then no attribute was found
                if (SAttribute != null) {
                    Serialization.GetFactory(SAttribute.FactoryName).SetSerializeType(T);
                }

                if (DAttribute != null) {
                    Serialization.GetFactory(DAttribute.FactoryName).SetDeserializeType(T);
                }
            }
        }


    }
}
