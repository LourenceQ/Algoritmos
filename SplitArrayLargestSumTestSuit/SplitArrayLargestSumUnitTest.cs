using FluentAssertions;
using SplitArrayLargestSumAlgorithm;
using Xunit;

namespace SplitArrayLargestSumTestSuit;

public class SplitArrayLargestSumUnitTest
{
    public static IEnumerable<object[]> TestData =>
        [
            [new int[] { 7, 2, 5, 10, 8 }, 2, 18]
        ];

    [Theory]
    [MemberData(nameof(TestData))]
    public static void SplitArrayLargestSum_Deve_Retornar_True(int[] data, int m, int expectedResult)
    {
        // Arrange, Act
        var sut = SplitArrayLargestSum.Validate(data, m);

        // Assert
        sut.Should().Be(expectedResult);
    }
}
