using Xunit;
using FluentAssertions;
using SubtractTheProductAndSumOfDigitsOfAnIntegerAlgotithm;

namespace SubtractTheProductAndSumOfDigitsOfAnIntegerTestSuit;

public class SubtractTheProductAndSumOfDigitsOfAnIntegerUnitTest
{
    [Theory]
    [InlineData(234, 15)]
    [InlineData(4421, 21)]
    [InlineData(0, 0)]
    public void SubtractTheProductAndSumOfDigitsOfAnInteger_Deve_Ser_True(int input, int output)
    {
        SubtractTheProductAndSumOfDigitsOfAnInteger.Validate(input).Should().Be(output);
        SubtractTheProductAndSumOfDigitsOfAnInteger.Validate(input).Should().Be(output);
        SubtractTheProductAndSumOfDigitsOfAnInteger.Validate(input).Should().Be(output);
    }
}
