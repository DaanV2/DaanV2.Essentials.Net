/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Collections.Generic;
using System.IO;

namespace DaanV2.Serialization {
    public static partial class Serialization {
        /// <summary>The internal list of factories.</summary>
        public static Dictionary<String, ISerializerFactory<Stream>> Factories {
            get => Serialization._Factories;
            set => Serialization._Factories = value;
        }
    }
}
