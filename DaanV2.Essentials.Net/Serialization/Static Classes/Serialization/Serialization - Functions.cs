/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace DaanV2.Serialization {
    public static partial class Serialization {
        /// <summary>Returns a list of names of all factories currently in the internal list.</summary>
        /// <returns>Returns a list of names of all factories currently in the internal list.</returns>
        [return: NotNull]
        public static List<String> GetFactoryNames() {
            var Out = new List<String>(Serialization._Factories.Count);

            foreach (KeyValuePair<String, ISerializerFactory<Stream>> T in Serialization._Factories) {
                Out.Add(T.Value.Name);
            }

            return Out;
        }
    }
}
