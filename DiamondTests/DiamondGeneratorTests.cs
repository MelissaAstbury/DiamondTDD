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
    }
}