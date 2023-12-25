
namespace DaanV2 {
    /// <summary>The interface responsible replacing the specified value with another.</summary>
    /// <typeparam name="T">The old and new type to replace.</typeparam>
    public interface IReplaceable<T> : IReplaceable<T, T> {
    }

    /// <summary>The interface responsible replacing the specified value with another.</summary>
    /// <typeparam name="TypeOld">The old type.</typeparam>
    /// <typeparam name="TypeNew">The new type.</typeparam>
    public interface IReplaceable<TypeOld, TypeNew> {
        /// <summary>Replaces the old value with the new value.</summary>
        /// <param name="OldValue">The old value to replace.</param>
        /// <param name="NewValue">The new value to insert.</param>
        void Replace(TypeOld OldValue, TypeNew NewValue);
    }
}