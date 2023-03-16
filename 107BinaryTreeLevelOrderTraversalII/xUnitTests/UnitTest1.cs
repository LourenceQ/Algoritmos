using MainProj;

namespace xUnitTests;

public class UnitTest1
{
    [Theory]
    [ClassData(typeof(SolutionTest))]
    public void Test1(int[] inorder, int[] postorder, int?[] expectedResult)
    {
        // Arrange
        Solution solution = new Solution();

        // Act
        var result = solution.BuildTree(inorder, postorder);

        // Assert
        Assert.Equal(expectedResult.Length, CountNodes(result));
        Assert.Equal(expectedResult, GetValues(result));
    }

    private int CountNodes(TreeNode root)
    {
        if(root == null) return 0;

        return CountNodes(root.left) + CountNodes(root.right) + 1;
    }

    private int?[] GetValues(TreeNode root)
    {
        if(root == null) return Array.Empty<int?>();

        var leftValues = GetValues(root.left);
        var rightValues = GetValues(root.right);

        var values = new int?[leftValues.Length + rightValues.Length + 1];

        Array.Copy(leftValues, values, leftValues.Length);
        Array.Copy(rightValues, 0, values, leftValues.Length+1, rightValues.Length);
        values[leftValues.Length] = root.val;

        return values;
    }

}