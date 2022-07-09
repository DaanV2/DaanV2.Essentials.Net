/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

namespace DaanV2.Converters {
    /// <summary>The interface responsible for forming the contract on how Converter should work with context.</summary>
    /// <typeparam name="TypeFrom">The object to convert into the specified type.</typeparam>
    /// <typeparam name="TypeTo">The type that is returned after conversion.</typeparam>
    /// <typeparam name="TypeContext">The type of the context.</typeparam>
    public interface IConverterInto<TypeFrom, TypeTo, TypeContext> {

        /// <summary>Convert the given object into the specified type.</summary>
        /// <param name="Process">The object to convert.</param>
        /// <param name="Context">The context needed to convert the given object.</param>
        /// <param name="Into">The object that receives the converted object.</param>
        void Convert(TypeFrom Process, TypeContext Context, TypeTo Into);
    }
}