using _958CheckCompletenessofaBinaryTreeProj;

namespace _958CheckCompletenessofaBinaryTreeTests;

public class NewXUnit
{
    [Theory]
    [ClassData(typeof(SolutionTest))]
    public void Test1(TreeNode root, bool expectedResult)
    {   
        // Arrange
        Solution solution = new Solution();

        // Act
        bool result = solution.IsCompleteTree(root);

        // Assert
        Assert.Equal(expectedResult, result);    
    }
}