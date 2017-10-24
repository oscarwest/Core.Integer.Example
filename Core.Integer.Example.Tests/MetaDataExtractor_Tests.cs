using Core.Integer.Example.App;
using NUnit.Framework;

namespace Core.Integer.Example.Tests
{
    public class MetaDataExtractor_Tests
    {
        [Theory]
        [TestCase(
            new int [] { 2, -2 },
            1,
            1,
            0,
            0
            )]
        public void GenerateIntArrayMetaData_ReturnsValidModel(int[] array, int negativeCount, int positiveCount, int avg, int sum)
        {
            // Arrange
            // Act
            var result = MetaDataExtractor.Generate(array);

            // Assert
            Assert.AreEqual(result.Negatives, negativeCount);
            Assert.AreEqual(result.Positives, positiveCount);
            Assert.AreEqual(result.Avg, avg);
            Assert.AreEqual(result.Sum, sum);

        }

    }
}
