using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//DOLATER prune namespace: DaanV2.Serialization
namespace DaanV2.Serialization {
    ///DOLATER <summary> add description for interface: IConfigSerializerFactory</summary>
    public interface IConfigSerializerFactory {

        ///DOLATER <summary>Add Description</summary>
        /// <param name="ForType"></param>
        /// <returns></returns>
        ISerializer<TIn> GetSerializer<TIn>();

        ///DOLATER <summary>Add Description</summary>
        /// <param name="ForType"></param>
        /// <returns></returns>
        ISerializer<Object> GetSerializer(Type ForType);


        ///DOLATER <summary>Add Description</summary>
        /// <returns></returns>
        IDeserializer<TOut> GetDeserializer<TOut>();

        ///DOLATER <summary>Add Description</summary>
        /// <param name="ForType"></param>
        /// <returns></returns>
        IDeserializer<Object> GetDeserializer(Type ForType);


        ///DOLATER <summary>Add Description</summary>
        String Name { get; }
    }
}
