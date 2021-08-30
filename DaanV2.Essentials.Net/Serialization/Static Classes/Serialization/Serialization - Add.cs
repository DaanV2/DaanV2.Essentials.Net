/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;

namespace DaanV2.Serialization {
    public static partial class Serialization {

        /// <summary>Add the given factory into the internal list.</summary>
        /// <param name="Factory">The factory to add.</param>
        public static void Add([NotNull] ISerializerFactory<Stream> Factory) {
            //If an older factory exists
            if (Serialization._Factories.ContainsKey(Factory.Name)) {
                //Transfer info
                ISerializerFactory<Stream> Old = Serialization._Factories[Factory.Name];
                Factory.SetDeserializeType(Old.GetDeserializeType());
                Factory.SetSerializeType(Old.GetSerializeType());
            }

            //Add factory to list
            Serialization._Factories[Factory.Name] = Factory;
        }

        /// <summary>Add the contents of assemblies to the internal list of factories.</summary>
        /// <param name="assemblies">The assemblies to loop through.</param>
        public static void Add([NotNull] Assembly[] assemblies) {
            for (Int32 I = 0; I < assemblies.Length; I++) {
                try {
                    Add(assemblies[I]);
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>Add the contents of a assembly to the internal list of factories.</summary>
        /// <param name="assembly">The assembly to look through.</param>
        public static void Add([NotNull] Assembly assembly) {
            Type Current;
            SerializerAttribute SAttribute;
            DeserializerAttribute DAttribute;
            Type[] Types = assembly.GetTypes();
            Int32 Max = Types.Length;

            //Loop through all types
            for (Int32 I = 0; I < Max; I++) {
                Current = Types[I];

                //Does the type implement ISerializerFactory?
                if (Current.ContainsInterface(typeof(ISerializerFactory<Stream>))) {
                    Add((ISerializerFactory<Stream>)Activator.CreateInstance(Current));
                }

                //Grab the attributes
                SAttribute = Current.GetAttribute<SerializerAttribute>();
                DAttribute = Current.GetAttribute<DeserializerAttribute>();

                //If null then no attribute was found
                if (SAttribute != null) {
                    Serialization.GetFactory(SAttribute.FactoryName).SetSerializeType(Current);
                }

                if (DAttribute != null) {
                    Serialization.GetFactory(DAttribute.FactoryName).SetDeserializeType(Current);
                }
            }
        }
    }
}
