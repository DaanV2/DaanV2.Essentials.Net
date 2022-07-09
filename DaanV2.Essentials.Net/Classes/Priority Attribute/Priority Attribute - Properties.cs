/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;

namespace DaanV2 {
    public partial class PriorityAttribute {
        /// <summary>Get or sets the value this priority has.</summary>
        public Int32 Value {
            get => this._Value;
            set => this._Value = value;
        }
    }
}