using System.Collections.Generic;

namespace DaanV2.Builders {
    ///DOLATER <summary> add description for interface: IBuilderAdd</summary>
    public interface IBuilderAdd<TypeToAdd> {
        /// <summary>Adds the specific object to the build</summary
        /// <param name="O">The object to check if it can be added</param>
        void Add(TypeToAdd O);


        /// <summary>Adds the specific object to the build</summary
        /// <param name="values">The objects to check if it can be added</param>
        void Add(IEnumerable<TypeToAdd> values);
    }
}
