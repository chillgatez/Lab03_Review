using Xunit;
using Lab03_Review;

namespace Lab03_ReviewTest
{
    public class ProgramTest1
    {
        [Theory]
        [InlineData ("1 2 3", 6)]
        [InlineData ("1 2 3 4", 6)]
        [InlineData ("1 2", 0)]
        [InlineData ("-1 -2 -3", -6)]
        public void CodeChallenge1Test(string testInput, int expectedProduct)
        {
            int actualProduct = Program.CalculatedProduct(testInput);

            Assert.Equal(expectedProduct, actualProduct);
        }

        [Theory]
        [InlineData("1 2 3", 6)]
        [InlineData("1 2 3 4", 6)]
        [InlineData("1 2", 0)]
        [InlineData("-1 -2 -3", -6)]
        public void CodeChallenge2Test(string testInput, int expectedProduct)
        {
            int actualProduct = Program.CalculatedProduct(testInput);

            Assert.Equal(expectedProduct, actualProduct);
        }
    }
}