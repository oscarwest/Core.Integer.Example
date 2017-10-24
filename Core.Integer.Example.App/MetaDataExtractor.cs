using System.Linq;
using Core.Integer.Example.App.Models;
using Core.Linq.Extensions;

namespace Core.Integer.Example.App
{
    public class MetaDataExtractor
    {
        public static ArrayMetadata Generate(int[] array)
        {
            var tuple = array.Partition(i => i > 0 );
            var sum = array.Aggregate((a, b) => a + b);
            var avg = array.Select(x => x).Where(x => x != 0).DefaultIfEmpty(0).Average();

            return new ArrayMetadata()
            {
                Negatives = tuple.negatives.Count,
                Positives = tuple.positives.Count,
                Sum = sum,
                Avg = avg
            };
        }
    }
}
