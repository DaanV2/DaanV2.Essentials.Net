/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Collections.Generic;

namespace DaanV2.Serialization {
    /// <summary>The class that holds all the serializer factories.</summary>
    public static partial class Serialization {
        /// <summary>Creates a new instance of <see cref="Serialization"/>.</summary>
        static Serialization() {
            Serialization._Factories = new Dictionary<String, ISerializerFactory<System.IO.Stream>>();
            Serialization.Add(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}