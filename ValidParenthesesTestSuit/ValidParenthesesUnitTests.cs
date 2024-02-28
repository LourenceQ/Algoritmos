using FluentAssertions;
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
        // Arrange, Act, Act
        Assert.True(Program.IsValid(input));
    }

    [Theory]
    [InlineData("{{}}{}{}[]][][")]
    [InlineData("{{}}{}]][][")]
    [InlineData("{{}}{}{}[]]][")]
    [InlineData("{{}}{}{}[]][")]
    public static void IsValid_Deve_Retornar_False(string input)
    {
        // Arrange, Assert
        bool res = Program.IsValid(input);

        // Act
        res.Should().BeFalse();
    }

    [Fact]
    public static void IsValid_Deve_Retornar_False_Para_Null()
    {
        // Assert, Arrange, Assert
        Program.IsValid(null).Should().BeFalse();
    }

    [Fact]
    public static void IsValid_Deve_Retornar_NaoLancar_Excecao_Para_Null()
    {
        // Assert, Arrange, Assert
        //Assert.Throws<NullReferenceException>(() => Program.IsValid(null));

        Assert.Null(Record.Exception(() => Program.IsValid(null)));
    }

}
