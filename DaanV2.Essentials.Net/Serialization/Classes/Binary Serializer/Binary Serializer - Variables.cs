/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System.Runtime.Serialization.Formatters.Binary;

namespace DaanV2.Serialization {
#if !NET5
    public partial class BinarySerializer<TypeSerialize> {
        /// <summary>The serializer used in the background.</summary>
        private readonly BinaryFormatter _Serializer;
    }
#endif
}
