using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForWriteUps.Interfaces;

namespace ForWriteUps.Classes
{
    public class ComparerBuilder<T> : IComparerBuilder<T>, IThenKeyComparerBuilder<T>
        {
            private readonly IReadOnlyList<IComparer<T>> comparers;

            public ComparerBuilder()
            {
                comparers = new List<IComparer<T>>();
            }

            private ComparerBuilder(IReadOnlyList<IComparer<T>> comparers)
            {
                this.comparers = comparers;
            }

            public IThenKeyComparerBuilder<T> SortKey<TKey>(Func<T, TKey> selector) where TKey : IComparable<TKey>
            {
                var comparer = Comparer<T>.Create((a, b) => selector(a).CompareTo(selector(b)));
                var newComparers = comparers.ToList();
                newComparers.Add(comparer);
                return new ComparerBuilder<T>(newComparers);
            }

            public IThenKeyComparerBuilder<T> SortKeyDescending<TKey>(Func<T, TKey> selector) where TKey : IComparable<TKey>
            {
                var comparer = Comparer<T>.Create((a, b) => selector(b).CompareTo(selector(a)));
                var newComparers = comparers.ToList();
                newComparers.Add(comparer);
                return new ComparerBuilder<T>(newComparers);
            }

            public IComparer<T> Build()
            {
                return Comparer<T>.Create((a, b) =>
                {
                    //no Linq. no foreach. We want this to be as quick as possible.
                    for (var i = 0; i < comparers.Count; i++)
                    {
                        var comparer = comparers[i];
                        var comparison = comparer.Compare(a, b);
                        if (comparison != 0)
                        {
                            return comparison;
                        }
                    }

                    return 0;
                });
            }

            public IThenKeyComparerBuilder<T> ThenKey<TKey>(Func<T, TKey> selector) where TKey : IComparable<TKey>
            {
                return SortKey(selector);
            }

            public IThenKeyComparerBuilder<T> ThenKeyDescending<TKey>(Func<T, TKey> selector) where TKey : IComparable<TKey>
            {
                return SortKeyDescending(selector);
            }
        }

}
