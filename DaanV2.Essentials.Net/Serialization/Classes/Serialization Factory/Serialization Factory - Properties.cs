/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;
using System.Runtime.Serialization;

namespace DaanV2.Serialization {
    public partial class SerializationFactory {
        /// <summary>The name of this factory.</summary>
        [DataMember]
        public String Name {
            get => this._Name;
            set => this._Name = value;
        }

        /// <summary>The type of the deserializer.</summary>
        [DataMember]
        public Type Deserializer {
            get => this._Deserializer;
            set => this._Deserializer = value;
        }

        /// <summary>The type of the serializer.</summary>
        [DataMember]
        public Type Serializer {
            get => this._Serializer;
            set => this._Serializer = value;
        }
    }
}
