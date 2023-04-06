using _1254NumberOfClosedIslandsProj;

namespace _1254NumberOfClosedIslandsTests;

public class SolutionTests
{
    [Theory]
    [ClassData(typeof(GridTestData))]
    public void ClosedIsland_ShouldReturnCorrectResult(int[][] grid, int expected)
    {
        // Arrange
        var solution = new Solution();

        // Act
        var result = solution.ClosedIsland(grid);

        // Assert
        Assert.Equal(expected, result);
    }
}