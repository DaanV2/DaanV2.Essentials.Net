using System;
using System.Collections.Generic;

namespace DaanV2.Converters {
    public static partial class ConverterExtension {

        #region Normal

        /// <summary>Converts the given object into the specified type.</summary>
        /// <typeparam name="TypeFrom">The type that is going to be converted.</typeparam>
        /// <typeparam name="TypeTo">The returning type after conversion.</typeparam>
        /// <param name="Converter">The converter to be used.</param>
        /// <param name="Process">The object to convert.</param>
        /// <param name="Receiver">The object to receive the converted object.</param>
        /// <returns>Converts the given object into the specified type.</returns>
        public static void Convert<TypeFrom, TypeTo>(this IConverterInto<TypeFrom, TypeTo> Converter, TypeFrom[] Process, TypeTo Receiver) {
            Int32 Length = Process.Length;

            for (Int32 I = 0; I < Length; I++) {
                Converter.Convert(Process[I], Receiver);
            }
        }

        /// <summary>Converts the given object into the specified type.</summary>
        /// <typeparam name="TypeFrom">The type that is going to be converted.</typeparam>
        /// <typeparam name="TypeTo">The returning type after conversion.</typeparam>
        /// <param name="Converter">The converter to be used.</param>
        /// <param name="Process">The object to convert.</param>
        /// <param name="Receiver">The object to receive the converted object.</param>
        /// <returns>Converts the given object into the specified type.</returns>
        public static void Convert<TypeFrom, TypeTo>(this IConverterInto<TypeFrom, TypeTo> Converter, List<TypeFrom> Process, TypeTo Receiver) {
            Int32 Length = Process.Count;            

            for (Int32 I = 0; I < Length; I++) {
                Converter.Convert(Process[I], Receiver);
            }
        }

        /// <summary>Converts the given object into the specified type.</summary>
        /// <typeparam name="TypeFrom">The type that is going to be converted.</typeparam>
        /// <typeparam name="TypeTo">The returning type after conversion.</typeparam>
        /// <param name="Converter">The converter to be used.</param>
        /// <param name="Process">The object to convert.</param>
        /// <param name="Receiver">The object to receive the converted object.</param>
        /// <returns>Converts the given object into the specified type.</returns>
        public static void Convert<TypeFrom, TypeTo>(this IConverterInto<TypeFrom, TypeTo> Converter, IList<TypeFrom> Process, TypeTo Receiver) {
            Int32 Length = Process.Count;            

            for (Int32 I = 0; I < Length; I++) {
                Converter.Convert(Process[I], Receiver);
            }
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
        /// <param name="Receiver">The object to receive the converted object.</param>
        /// <returns>Converts the given object into the specified type.</returns>
        public static void Convert<TypeFrom, TypeTo, TypeContext>(this IConverterInto<TypeFrom, TypeTo, TypeContext> Converter, TypeFrom[] Process, TypeContext Context, TypeTo Receiver) {
            Int32 Length = Process.Length;            

            for (Int32 I = 0; I < Length; I++) {
                Converter.Convert(Process[I], Context, Receiver);
            }
        }

        /// <summary>Converts the given object into the specified type.</summary>
        /// <typeparam name="TypeFrom">The type that is going to be converted.</typeparam>
        /// <typeparam name="TypeTo">The returning type after conversion.</typeparam>
        /// <typeparam name="TypeContext">The context needed to convert.</typeparam>
        /// <param name="Converter">The converter to be used.</param>
        /// <param name="Process">The object to convert.</param>
        /// <param name="Context">The context needed to convert  the object.</param>
        /// <param name="Receiver">The object to receive the converted object.</param>
        /// <returns>Converts the given object into the specified type.</returns>
        public static void Convert<TypeFrom, TypeTo, TypeContext>(this IConverterInto<TypeFrom, TypeTo, TypeContext> Converter, List<TypeFrom> Process, TypeContext Context, TypeTo Receiver) {
            Int32 Length = Process.Count;            

            for (Int32 I = 0; I < Length; I++) {
                Converter.Convert(Process[I], Context, Receiver);
            }
        }

        /// <summary>Converts the given object into the specified type.</summary>
        /// <typeparam name="TypeFrom">The type that is going to be converted.</typeparam>
        /// <typeparam name="TypeTo">The returning type after conversion.</typeparam>
        /// <typeparam name="TypeContext">The context needed to convert.</typeparam>
        /// <param name="Converter">The converter to be used.</param>
        /// <param name="Process">The object to convert.</param>
        /// <param name="Context">The context needed to convert  the object.</param>
        /// <param name="Receiver">The object to receive the converted object.</param>
        /// <returns>Converts the given object into the specified type.</returns>
        public static void Convert<TypeFrom, TypeTo, TypeContext>(this IConverterInto<TypeFrom, TypeTo, TypeContext> Converter, IList<TypeFrom> Process, TypeContext Context, TypeTo Receiver) {
            Int32 Length = Process.Count;

            for (Int32 I = 0; I < Length; I++) {
                Converter.Convert(Process[I], Context, Receiver);
            }
        }

        #endregion

        #region Tuple

        /// <summary>Converts the given object into the specified type.</summary>
        /// <typeparam name="TypeFrom">The type that is going to be converted.</typeparam>
        /// <typeparam name="TypeTo">The returning type after conversion.</typeparam>
        /// <typeparam name="TypeContext">The context needed to convert.</typeparam>
        /// <param name="Converter">The converter to be used.</param>
        /// <param name="Process">The object to convert.</param>
        /// <param name="Receiver">The object to receive the converted object.</param>
        /// <returns>Converts the given object into the specified type.</returns>
        public static void Convert<TypeFrom, TypeTo, TypeContext>(this IConverterInto<TypeFrom, TypeTo, TypeContext> Converter, (TypeFrom, TypeContext)[] Process, TypeTo Receiver) {
            Int32 Length = Process.Length;

            for (Int32 I = 0; I < Length; I++) {
                Converter.Convert(Process[I].Item1, Process[I].Item2, Receiver);
            }
        }

        /// <summary>Converts the given object into the specified type.</summary>
        /// <typeparam name="TypeFrom">The type that is going to be converted.</typeparam>
        /// <typeparam name="TypeTo">The returning type after conversion.</typeparam>
        /// <typeparam name="TypeContext">The context needed to convert.</typeparam>
        /// <param name="Converter">The converter to be used.</param>
        /// <param name="Process">The object to convert.</param>
        /// <param name="Receiver">The object to receive the converted object.</param>
        /// <returns>Converts the given object into the specified type.</returns>
        public static void Convert<TypeFrom, TypeTo, TypeContext>(this IConverterInto<TypeFrom, TypeTo, TypeContext> Converter, List<(TypeFrom, TypeContext)> Process, TypeTo Receiver) {
            Int32 Length = Process.Count;

            for (Int32 I = 0; I < Length; I++) {
                Converter.Convert(Process[I].Item1, Process[I].Item2, Receiver);
            }
        }

        /// <summary>Converts the given object into the specified type.</summary>
        /// <typeparam name="TypeFrom">The type that is going to be converted.</typeparam>
        /// <typeparam name="TypeTo">The returning type after conversion.</typeparam>
        /// <typeparam name="TypeContext">The context needed to convert.</typeparam>
        /// <param name="Converter">The converter to be used.</param>
        /// <param name="Process">The object to convert.</param>
        /// <param name="Receiver">The object to receive the converted object.</param>
        /// <returns>Converts the given object into the specified type.</returns>
        public static void Convert<TypeFrom, TypeTo, TypeContext>(this IConverterInto<TypeFrom, TypeTo, TypeContext> Converter, IList<(TypeFrom, TypeContext)> Process, TypeTo Receiver) {
            Int32 Length = Process.Count;            

            for (Int32 I = 0; I < Length; I++) {
                Converter.Convert(Process[I].Item1, Process[I].Item2, Receiver);
            }
        }

        #endregion

    }
}
