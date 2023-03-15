using System.Collections;
using _958CheckCompletenessofaBinaryTreeProj;

namespace _958CheckCompletenessofaBinaryTreeTests;

public class SolutionTest : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { null, true };
        yield return new object[] { new TreeNode(1), true };
        yield return new object[] { new TreeNode(1, new TreeNode(2)), false };
        yield return new object[] { new TreeNode(1, null, new TreeNode(2)), false };
        yield return new object[] { new TreeNode(1, new TreeNode(2), new TreeNode(3)), true };
        yield return new object[] { new TreeNode(1, new TreeNode(2), null), false };
        yield return new object[] { new TreeNode(1, null, new TreeNode(2)), false };
        yield return new object[] { new TreeNode(1, new TreeNode(2), new TreeNode(3, null, new TreeNode(4))), false };
        yield return new object[] { new TreeNode(1, new TreeNode(2, new TreeNode(4)), new TreeNode(3)), false };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}