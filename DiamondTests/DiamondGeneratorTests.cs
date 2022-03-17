using Xunit;
using Shouldly;
using Diamond;

namespace DiamondTests
{
    public class DiamondGeneratorTests
    {
        [Fact]
        public void ShouldCreateNewDiamondGenerator()
        {
            DiamondGenerator generator = new();
            generator.ShouldNotBeNull();
            generator.ShouldBeOfType<DiamondGenerator>();
        }

        [Theory]
        [InlineData("C", "ABBCCBBA")]
        public void Task2(string character, string expectedResult)
        {
            DiamondGenerator generator = new();
            var result = generator.PrintDiamond(character);
            result.ShouldBe(expectedResult);
        }
    }
}