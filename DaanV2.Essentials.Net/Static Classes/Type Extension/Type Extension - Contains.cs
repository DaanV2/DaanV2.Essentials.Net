/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;

namespace DaanV2 {
    /// <summary>The class that extends op on the existing type code.</summary>
    public static partial class TypeExtension {

        /// <summary>Checks if the given type implement the given interface type.</summary>
        /// <param name="Object">The object to look through.</param>
        /// <param name="Contains">The interface type to find.</param>
        /// <returns>Checks if the given type implement the given interface type.</returns>
        public static Boolean ContainsInterface(this Type Object, Type Contains) {
            Type[] Interfaces = Object.GetInterfaces();

            if (Contains.IsGenericType) {
                for (Int32 I = 0; I < Interfaces.Length; I++) {
                    if (Interfaces[I].IsGenericType) {
                        if (Interfaces[I].GetGenericTypeDefinition() == Contains) {
                            return true;
                        }
                    }
                }
            }
            else {
                for (Int32 I = 0; I < Interfaces.Length; I++) {
                    if (Interfaces[I] == Contains) {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>Checks if the specified type contains a type of attribute.</summary>
        /// <param name="Object">The object to look through.</param>
        /// <param name="Contains">The type to find in attributes.</param>
        /// <param name="Inherit">true to search this member's inheritance chain to find the attributes; otherwise, false. This parameter is ignored for properties and events.</param>
        /// <returns>Checks if the specified type contains a type of attribute.</returns>
        public static Boolean ContainsAttribute(this Type Object, Type Contains, Boolean Inherit = true) {
            Object[] attributes = Object.GetCustomAttributes(Inherit);
            Int32 Length = attributes.Length;

            for (Int32 I = 0; I < Length; I++) {
                if (attributes[I].GetType() == Contains) {
                    return true;
                }
            }

            return false;
        }
    }
}
