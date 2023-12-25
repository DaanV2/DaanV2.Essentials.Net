using System;

namespace DaanV2.Serialization {
    /// <summary>The class that holds all the serializer factories.</summary>
    public static partial class Serialization {
        /// <summary>Creates a new instance of <see cref="Serialization"/>.</summary>
        static Serialization() {
            Serialization._Factories = new();
            Serialization.Add(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}