using System;

namespace DaanV2 {
    /// <summary>The static class that extends upon existing enumerator code</summary>
    public static partial class EnumeratorExtension {
        /// <summary>Replaces the value with the new specified value, might not work with flagged enumerator</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Value"></param>
        /// <param name="OldName"></param>
        /// <param name="NewName"></param>
        /// <returns></returns>
        public static T Replace<T>(this T Value, String OldName, String NewName)
            where T : Enum {
            Type TypeEnum = typeof(T);
            String[] Names = Enum.GetNames(TypeEnum);

            if (Names.Contains(OldName) && Names.Contains(NewName)) {
                var ShouldValue = (T)Enum.Parse(TypeEnum, OldName);

                if (Value.Equals(ShouldValue)) {
                    return (T)Enum.Parse(TypeEnum, NewName);
                }
            }

            return Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static String GetName<T>(this T Value)
            where T : Enum {
            return Enum.GetName(typeof(T), Value);
        }
    }
}
