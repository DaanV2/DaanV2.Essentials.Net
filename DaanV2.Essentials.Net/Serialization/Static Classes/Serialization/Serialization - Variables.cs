﻿using System;
using System.Collections.Generic;
using System.IO;

namespace DaanV2.Serialization {
    public static partial class Serialization {
        /// <summary>The internal list of factories.</summary>
        private static Dictionary<String, ISerializerFactory<Stream>> _Factories;
    }
}