namespace Tests;

using MainProj;
using Xunit;

public class SolutionTests
{
    [Theory]
    [ClassData(typeof(CountPairsTestData))]
    public void CountPairs_ShouldReturnExpectedResult(int n, int[][] edges, long expected)
    {
        // Arrange
        var solution = new Solution();

        // Act
        var result = solution.CountPairs(n, edges);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [ClassData(typeof(DfsTestData))]
    public void Dfs_ShouldReturnExpectedResult(int i, HashSet<int>[] paths, HashSet<int> visited, int expected)
    {
        // Arrange
        var solution = new Solution();

        // Act
        var result = solution.Dfs(i, paths, visited);

        // Assert
        Assert.Equal(expected, result);
    }

    // Test data for CountPairs method
    public class CountPairsTestData : TheoryData<int, int[][], long>
    {
        public CountPairsTestData()
        {
            Add(4, new int[][] { new int[] { 0, 1 }, new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 0 }, new int[] { 0, 2 }, new int[] { 1, 3 } }, 6);
            Add(5, new int[][] { new int[] { 0, 1 }, new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 0 } }, 5);
        }
    }

    // Test data for Dfs method
    public class DfsTestData : TheoryData<int, HashSet<int>[], HashSet<int>, int>
    {
        public DfsTestData()
        {
            var paths = new HashSet<int>[4];
            for (int i = 0; i < 4; i++)
            {
                paths[i] = new HashSet<int>();
            }
            paths[0].Add(1);
            paths[1].Add(0);
            paths[1].Add(2);
            paths[2].Add(1);
            paths[2].Add(3);
            paths[3].Add(2);

            Add(0, paths, new HashSet<int>(), 4);
            Add(1, paths, new HashSet<int>(), 3);
        }
    }
}
