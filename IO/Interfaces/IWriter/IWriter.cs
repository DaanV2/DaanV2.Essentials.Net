using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.IO {
    ///DOLATER <summary> add description for interface: IWriter</summary>
    public interface IWriter{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="O"></param>
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
        /// <param name="value"></param>
        void Write(TIn value);
    }
}
