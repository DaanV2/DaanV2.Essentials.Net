using System;

namespace DaanV2.IO {
    ///DOLATER <summary> add description for interface: IWriter</summary>
    public interface IWriter {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="O">FILL_ME_IN</param
        void Write(Object O);

        /// <summary>
        /// 
        /// </summary>
        void Flush();

        /// <summary>
        /// 
        /// </summary>
        void Close();
    }

    ///DOLATER <summary> add description for interface: IWriter</summary>
    public interface IWriter<TIn> : IWriter {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">FILL_ME_IN</param
        void Write(TIn value);
    }
}
