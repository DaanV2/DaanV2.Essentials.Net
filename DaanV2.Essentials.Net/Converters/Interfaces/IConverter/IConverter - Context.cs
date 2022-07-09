/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

namespace DaanV2.Converters {
    /// <summary>The interface that is responsible for forming the contract on how Converters should work with context.</summary>
    /// <typeparam name="TypeFrom">The type that is going to be converted.</typeparam>
    /// <typeparam name="TypeTo">The returning type after conversion.</typeparam>
    /// <typeparam name="TypeContext">The context needed to convert.</typeparam>
    public interface IConverter<TypeFrom, TypeTo, TypeContext> {

        /// <summary>Converts the given object into the specified type.</summary>
        /// <param name="Process">The object to convert.</param>
        /// <param name="Context">The context needed to convert  the object.</param>
        /// <returns>Converts the given object into the specified type.</returns>
        TypeTo Convert(TypeFrom Process, TypeContext Context);
    }
}