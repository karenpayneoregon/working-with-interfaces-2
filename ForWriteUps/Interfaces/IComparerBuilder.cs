using System;

namespace ForWriteUps.Interfaces
{
    public interface IComparerBuilder<T> : IComparerBuild<T>
    {
        IThenKeyComparerBuilder<T> SortKey<TKey>(Func<T, TKey> selector) where TKey : IComparable<TKey>;
        IThenKeyComparerBuilder<T> SortKeyDescending<TKey>(Func<T, TKey> selector) where TKey : IComparable<TKey>;
    }
}