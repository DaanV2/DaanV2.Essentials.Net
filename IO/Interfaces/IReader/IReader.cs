using System;

namespace DaanV2.IO {
    ///DOLATER <summary> add description for interface: IReader</summary>
    public interface IReader {
        ///DOLATER <summary> add description</summary>
        /// <param name="O"></param>
        Object Read();

        ///DOLATER <summary> add description</summary>
        void Flush();

        ///DOLATER <summary> add description</summary>
        void Close();
    }
}
