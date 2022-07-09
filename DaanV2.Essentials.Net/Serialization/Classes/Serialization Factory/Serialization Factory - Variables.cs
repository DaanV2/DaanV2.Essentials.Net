/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;

namespace DaanV2.Serialization {
    public partial class SerializationFactory {
        /// <summary>The name of this factory.</summary>
        private protected String _Name;

        /// <summary>The type of the deserializer.</summary>
        private protected Type _Deserializer;

        /// <summary>The type of the serializer.</summary>
        private protected Type _Serializer;
    }
}