using System;
using System.Linq;

namespace Core.Integer.Example.App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Array.ConvertAll(args, i => int.Parse(i));

            var metadata = MetaDataExtractor.Generate(array);

            System.Console.WriteLine($"Negatives: {metadata.Negatives}, Positives: {metadata.Positives}, Sum: {metadata.Sum}, Average: {metadata.Avg}");
        }
    }
}
