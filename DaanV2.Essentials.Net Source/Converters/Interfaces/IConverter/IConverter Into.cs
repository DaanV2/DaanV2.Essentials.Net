/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/

namespace DaanV2.Converters {
    /// <summary>The interface responsible for forming the contract on how converters should work.</summary>
    /// <typeparam name="TypeFrom">The type to convert.</typeparam>
    /// <typeparam name="TypeTo">The type that receives the given output.</typeparam>
    public interface IConverterInto<TypeFrom, TypeTo> {

        /// <summary>Converts the given type into the specified class.</summary>
        /// <param name="Process">The object to convert.</param>
        /// <param name="Receiver">The object to receive the converted object.</param>
        void Convert(TypeFrom Process, TypeTo Receiver);
    }
}
