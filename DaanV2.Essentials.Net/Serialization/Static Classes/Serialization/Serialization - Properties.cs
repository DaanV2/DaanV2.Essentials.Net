/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace DaanV2.Serialization {
    public static partial class Serialization {
        /// <summary>The internal list of factories.</summary>
        public static Dictionary<String, ISerializerFactory<Stream>> Factories {
            [return: NotNull]
            get => Serialization._Factories;            
            set {
                if (value is null) throw new ArgumentNullException(nameof(Factories));

                Serialization._Factories = value;
            }
        }
    }
}
