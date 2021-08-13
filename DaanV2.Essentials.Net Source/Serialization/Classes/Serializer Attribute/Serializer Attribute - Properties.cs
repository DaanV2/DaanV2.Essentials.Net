/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Runtime.Serialization;

namespace DaanV2.Serialization {
    public partial class SerializerAttribute {
        /// <summary>The name of the factory that this class belongs to.</summary>
        [DataMember]
        public String FactoryName {
            get => this._FactoryName;
            set => this._FactoryName = value;
        }
    }
}
