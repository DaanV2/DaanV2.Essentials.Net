/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

namespace DaanV2.Binary {
    /// <summary>The enumerator that marks how data is saved, or should be saved</summary>
    public enum Endianness {
        /// <summary>Marks that the ordering places the most significant byte last and the least significant byte first</summary>
        LittleEndian,
        /// <summary>Marks that the ordering places the most significant byte first and the least significant byte last</summary>
        BigEndian
    }
}
