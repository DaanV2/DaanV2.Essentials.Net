using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.IO {
    ///DOLATER <summary> add description for interface: IReader</summary>
    public interface IReader{
        ///DOLATER <summary> add description</summary>
        /// <param name="O"></param>
        Object Read();

        ///DOLATER <summary> add description</summary>
        void Flush();

        ///DOLATER <summary> add description</summary>
        void Close();
    }

    ///DOLATER <summary> add description for interface: IReader</summary>
    public interface IReader<TOut> : IReader {
        ///DOLATER <summary> add description</summary>
        /// <param name="value"></param>
        TOut Read();        
    }
}
