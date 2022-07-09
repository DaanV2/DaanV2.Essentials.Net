using System;

namespace DaanV2.Binary {
    public partial struct BitFlags8 {
        /// <summary>Gets or sets the first flag</summary>
        public Boolean Flag1 { get => BitFlags.GetFlag(this._Flags, 0); set => BitFlags.SetFlag(ref this._Flags, 0, value); }

        /// <summary>Gets or sets the second flag</summary>
        public Boolean Flag2 { get => BitFlags.GetFlag(this._Flags, 1); set => BitFlags.SetFlag(ref this._Flags, 1, value); }

        /// <summary>Gets or sets the third flag</summary>
        public Boolean Flag3 { get => BitFlags.GetFlag(this._Flags, 2); set => BitFlags.SetFlag(ref this._Flags, 2, value); }

        /// <summary>Gets or sets the fourth flag</summary>
        public Boolean Flag4 { get => BitFlags.GetFlag(this._Flags, 3); set => BitFlags.SetFlag(ref this._Flags, 3, value); }

        /// <summary>Gets or sets the fifth flag</summary>
        public Boolean Flag5 { get => BitFlags.GetFlag(this._Flags, 4); set => BitFlags.SetFlag(ref this._Flags, 4, value); }

        /// <summary>Gets or sets the sixth flag</summary>
        public Boolean Flag6 { get => BitFlags.GetFlag(this._Flags, 5); set => BitFlags.SetFlag(ref this._Flags, 5, value); }

        /// <summary>Gets or sets the seventh flag</summary>
        public Boolean Flag7 { get => BitFlags.GetFlag(this._Flags, 6); set => BitFlags.SetFlag(ref this._Flags, 6, value); }

        /// <summary>Gets or sets the eighth flag</summary>
        public Boolean Flag8 { get => BitFlags.GetFlag(this._Flags, 7); set => BitFlags.SetFlag(ref this._Flags, 7, value); }
    }
}