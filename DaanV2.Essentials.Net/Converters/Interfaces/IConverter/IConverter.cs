
namespace DaanV2.Converters {
    /// <summary>The interface responsible for forming the contract on how Converter should work.</summary>
    /// <typeparam name="TypeFrom">The object to convert into the specified type.</typeparam>
    /// <typeparam name="TypeTo">The type that is returned after conversion.</typeparam>
    public interface IConverter<TypeFrom, TypeTo> {

        /// <summary>Converts the given object into the specified type.</summary>
        /// <param name="Process">The object to convert.</param>
        /// <returns>Converts the given object into the specified type.</returns>
        TypeTo Convert(TypeFrom Process);
    }
}