using System;
using System.Collections.Generic;

namespace DaanV2.Converters {
    /// <summary>The static class that extends basic converter behaviour</summary>
    public static partial class ConverterExtension {

        #region Normal
        
        /// <summary>Converts the given object into the specified type.</summary>
        /// <typeparam name="TypeFrom">The type that is going to be converted.</typeparam>
        /// <typeparam name="TypeTo">The returning type after conversion.</typeparam>
        /// <param name="Converter">The converter to be used.</param>
        /// <param name="Process">The object to convert.</param>
        /// <returns>Converts the given object into the specified type.</returns>
        public static TypeTo[] Convert<TypeFrom, TypeTo>(this IConverter<TypeFrom, TypeTo> Converter, TypeFrom[] Process) {
            Int32 Length = Process.Length;
            TypeTo[] Out = new TypeTo[Length];

            for (Int32 I = 0; I < Length; I++) {
                Out[I] = Converter.Convert(Process[I]);
            }

            return Out;
        }

        /// <summary>Converts the given object into the specified type.</summary>
        /// <typeparam name="TypeFrom">The type that is going to be converted.</typeparam>
        /// <typeparam name="TypeTo">The returning type after conversion.</typeparam>
        /// <param name="Converter">The converter to be used.</param>
        /// <param name="Process">The object to convert.</param>
        /// <returns>Converts the given object into the specified type.</returns>
        public static TypeTo[] Convert<TypeFrom, TypeTo>(this IConverter<TypeFrom, TypeTo> Converter, List<TypeFrom> Process) {
            Int32 Length = Process.Count;
            TypeTo[] Out = new TypeTo[Length];

            for (Int32 I = 0; I < Length; I++) {
                Out[I] = Converter.Convert(Process[I]);
            }

            return Out;
        }

        /// <summary>Converts the given object into the specified type.</summary>
        /// <typeparam name="TypeFrom">The type that is going to be converted.</typeparam>
        /// <typeparam name="TypeTo">The returning type after conversion.</typeparam>
        /// <param name="Converter">The converter to be used.</param>
        /// <param name="Process">The object to convert.</param>
        /// <returns>Converts the given object into the specified type.</returns>
        public static TypeTo[] Convert<TypeFrom, TypeTo>(this IConverter<TypeFrom, TypeTo> Converter, IList<TypeFrom> Process) {
            Int32 Length = Process.Count;
            TypeTo[] Out = new TypeTo[Length];

            for (Int32 I = 0; I < Length; I++) {
                Out[I] = Converter.Convert(Process[I]);
            }

            return Out;
        }

        #endregion

        #region Context

        /// <summary>Converts the given object into the specified type.</summary>
        /// <typeparam name="TypeFrom">The type that is going to be converted.</typeparam>
        /// <typeparam name="TypeTo">The returning type after conversion.</typeparam>
        /// <typeparam name="TypeContext">The context needed to convert.</typeparam>
        /// <param name="Converter">The converter to be used.</param>
        /// <param name="Process">The object to convert.</param>
        /// <param name="Context">The context needed to convert  the object.</param>
        /// <returns>Converts the given object into the specified type.</returns>
        public static TypeTo[] Convert<TypeFrom, TypeTo, TypeContext>(this IConverter<TypeFrom, TypeTo, TypeContext> Converter, TypeFrom[] Process, TypeContext Context) {
            Int32 Length = Process.Length;
            TypeTo[] Out = new TypeTo[Length];

            for (Int32 I = 0; I < Length; I++) {
                Out[I] = Converter.Convert(Process[I], Context);
            }

            return Out;
        }

        /// <summary>Converts the given object into the specified type.</summary>
        /// <typeparam name="TypeFrom">The type that is going to be converted.</typeparam>
        /// <typeparam name="TypeTo">The returning type after conversion.</typeparam>
        /// <typeparam name="TypeContext">The context needed to convert.</typeparam>
        /// <param name="Converter">The converter to be used.</param>
        /// <param name="Process">The object to convert.</param>
        /// <param name="Context">The context needed to convert  the object.</param>
        /// <returns>Converts the given object into the specified type.</returns>
        public static TypeTo[] Convert<TypeFrom, TypeTo, TypeContext>(this IConverter<TypeFrom, TypeTo, TypeContext> Converter, List<TypeFrom> Process, TypeContext Context) {
            Int32 Length = Process.Count;
            TypeTo[] Out = new TypeTo[Length];

            for (Int32 I = 0; I < Length; I++) {
                Out[I] = Converter.Convert(Process[I], Context);
            }

            return Out;
        }

        /// <summary>Converts the given object into the specified type.</summary>
        /// <typeparam name="TypeFrom">The type that is going to be converted.</typeparam>
        /// <typeparam name="TypeTo">The returning type after conversion.</typeparam>
        /// <typeparam name="TypeContext">The context needed to convert.</typeparam>
        /// <param name="Converter">The converter to be used.</param>
        /// <param name="Process">The object to convert.</param>
        /// <param name="Context">The context needed to convert  the object.</param>
        /// <returns>Converts the given object into the specified type.</returns>
        public static TypeTo[] Convert<TypeFrom, TypeTo, TypeContext>(this IConverter<TypeFrom, TypeTo, TypeContext> Converter, IList<TypeFrom> Process, TypeContext Context) {
            Int32 Length = Process.Count;
            TypeTo[] Out = new TypeTo[Length];

            for (Int32 I = 0; I < Length; I++) {
                Out[I] = Converter.Convert(Process[I], Context);
            }

            return Out;
        }

        #endregion

        #region Tuple

        /// <summary>Converts the given object into the specified type.</summary>
        /// <typeparam name="TypeFrom">The type that is going to be converted.</typeparam>
        /// <typeparam name="TypeTo">The returning type after conversion.</typeparam>
        /// <typeparam name="TypeContext">The context needed to convert.</typeparam>
        /// <param name="Converter">The converter to be used.</param>
        /// <param name="Process">The object to convert.</param>
        /// <returns>Converts the given object into the specified type.</returns>
        public static TypeTo[] Convert<TypeFrom, TypeTo, TypeContext>(this IConverter<TypeFrom, TypeTo, TypeContext> Converter, (TypeFrom, TypeContext)[] Process) {
            Int32 Length = Process.Length;
            TypeTo[] Out = new TypeTo[Length];

            for (Int32 I = 0; I < Length; I++) {
                Out[I] = Converter.Convert(Process[I].Item1, Process[I].Item2);
            }

            return Out;
        }

        /// <summary>Converts the given object into the specified type.</summary>
        /// <typeparam name="TypeFrom">The type that is going to be converted.</typeparam>
        /// <typeparam name="TypeTo">The returning type after conversion.</typeparam>
        /// <typeparam name="TypeContext">The context needed to convert.</typeparam>
        /// <param name="Converter">The converter to be used.</param>
        /// <param name="Process">The object to convert.</param>
        /// <returns>Converts the given object into the specified type.</returns>
        public static TypeTo[] Convert<TypeFrom, TypeTo, TypeContext>(this IConverter<TypeFrom, TypeTo, TypeContext> Converter, List<(TypeFrom, TypeContext)> Process) {
            Int32 Length = Process.Count;
            TypeTo[] Out = new TypeTo[Length];

            for (Int32 I = 0; I < Length; I++) {
                Out[I] = Converter.Convert(Process[I].Item1, Process[I].Item2);
            }

            return Out;
        }

        /// <summary>Converts the given object into the specified type.</summary>
        /// <typeparam name="TypeFrom">The type that is going to be converted.</typeparam>
        /// <typeparam name="TypeTo">The returning type after conversion.</typeparam>
        /// <typeparam name="TypeContext">The context needed to convert.</typeparam>
        /// <param name="Converter">The converter to be used.</param>
        /// <param name="Process">The object to convert.</param>
        /// <returns>Converts the given object into the specified type.</returns>
        public static TypeTo[] Convert<TypeFrom, TypeTo, TypeContext>(this IConverter<TypeFrom, TypeTo, TypeContext> Converter, IList<(TypeFrom, TypeContext)> Process) {
            Int32 Length = Process.Count;
            TypeTo[] Out = new TypeTo[Length];

            for (Int32 I = 0; I < Length; I++) {
                Out[I] = Converter.Convert(Process[I].Item1, Process[I].Item2);
            }

            return Out;
        }

        #endregion

    }
}
