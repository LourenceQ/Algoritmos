using MainProj;
using XUnitTests.Models;

namespace XUnitTests;

public class UnitTest1
{
    [Theory, ClassData(typeof(WindowsDataTest))]
    public void Test1(int[] param, int k, int[] expected)
    {
        // Arrange
        int[] res = Program.MaxSlidingWindow(param, k);
        // Act

        // Assert
        Assert.Equal(res, expected);
    }
}