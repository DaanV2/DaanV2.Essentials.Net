﻿using System;

namespace DaanV2.Serialization {
    public partial class DeserializerAttribute {
        /// <summary>The name of the factory this class belongs to.</summary>
        public String FactoryName {
            get => this._FactoryName;
            set => this._FactoryName = value;
        }
    }
}