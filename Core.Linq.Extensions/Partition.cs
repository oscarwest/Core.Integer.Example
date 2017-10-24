using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Linq.Extensions
{
    public static class LinqExtensions
    {
        public static (IList<T> positives, IList<T> negatives) Partition<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            return (
                positives: items.Where(i => predicate(i) == true).ToList(),
                negatives: items.Where(i => predicate(i) == false).ToList()
            );
        }
    }
}
