using MainProj;

namespace XUnitTests;

public class UnitTest1
{
    [Theory]
    [ClassData(typeof(MatrixTestData))]
    public void TestUpdateMatrix(int[][] input, int[][] expectedOutput)
    {
        
        var result = Solution.UpdateMatrix(input);

        Assert.Equal(expectedOutput, result);
    }
}