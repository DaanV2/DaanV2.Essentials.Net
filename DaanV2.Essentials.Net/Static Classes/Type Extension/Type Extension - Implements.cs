using System;

namespace DaanV2 {
    public static partial class TypeExtension {
        /// <summary>Check if the given type implements the specified type.</summary>
        /// <param name="Value">The value to check if it implements the specified type.</param>
        /// <param name="Contains">The type to find.</param>
        /// <returns>Check if the given type implements the specified type.</returns>
        public static Boolean Implements(this Type Value, Type Contains) {
            if (Contains.IsInterface && Value.ContainsInterface(Contains)) {
                return true;
            }

            Type Base = Value.BaseType;
            if (Base is null) {
                return false;
            }

            return Base == Contains || Base.Implements(Contains);
        }
    }
}