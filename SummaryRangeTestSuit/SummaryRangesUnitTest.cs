using FluentAssertions;
using SummaryRangesAlgorithm;
using Xunit;

namespace SummaryRangeTestSuit;
public class SummaryRangesUnitTest
{
    [Fact]
    public void SummaryRanges_Deve_Retornar_Ok()
    {
        // Arrange
        var res = SummaryRanges.Validate([0, 1, 2, 4, 5, 7]);

        // Act

        // Assert
        res.Should().NotBeNull();

    }
}
