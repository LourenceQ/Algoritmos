using MainProj;

namespace XUnitTests;

public class UnitTest1
{
    [Theory]
    [ClassData(typeof(DataTests))]
    public void Test1(string s, bool expected)
    {
        // Arrange

        // Act
        var sut = Program.RepeatedSubstringPattern(s);

        // Assert
        Assert.Equal(expected, sut);
    }
}