using FluentAssertions;
using ThirdMaximumNumberAlgorithm;
using Xunit;

namespace ThirdMaximumNumberTestSuit;

public class ThirdMaximumNumberUnitTests
{
    public static IEnumerable<object[]> TestData =>
    [
        [new int[] { 3, 2, 1 }, 1]
    ];


    [Theory]
    [MemberData(nameof(TestData))]
    public void ThirdMaximumNumber_Must_Be_True(int[] data, int expectedResult)
    {
        // Arrange, Act
        var sut = ThirdMaximumNumber.Validate(data);

        // Assert
        sut.Should().Be(expectedResult);
    }
}
