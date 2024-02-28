using ValidParenthesesAlgorithm;
using Xunit;

namespace ValidParenthesesTestSuit;
public class ValidParenthesesUnitTests
{
    [Theory]
    [InlineData("{{{}}}")]
    [InlineData("[{{}}]")]
    public static void IsValid_Deve_Retornar_Tue(string input)
    {
        // Arrange & Act
        var res = Program.IsValid(input);

        // Assert
        Assert.True(res);
    }
}
