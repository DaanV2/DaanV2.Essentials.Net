/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System.Xml.Serialization;

namespace DaanV2.Serialization {
    public partial class XmlSerializer<TypeSerialize> {

        /// <summary>The given xml serializer that connects to the interface.</summary>
        private protected XmlSerializer _Serializer;
    }
}