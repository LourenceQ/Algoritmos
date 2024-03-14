using FluentAssertions;
using StringToIntegerAlgorithm;
using Xunit;

namespace StringToIntegerTestSuit;

public class StringToIntegerUnitTest
{
    [Theory]
    [InlineData("42", 42)]
    [InlineData("-42", -42)]
    [InlineData("4193 with words", 4193)]
    public void StringToInteger_Deve_Ser_True(string s, int output)
    {
        StringToInteger.Validate(s).Should().Be(output);
    }
}
