using System.Collections;

namespace xUnitTests;

public class SolutionTest : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { new int[] { 9, 3, 15, 20, 7 }, new int[] { 9, 15, 7, 20, 3 }, new int?[] { 3, 9, 20, null, null, 15, 7 } };
        yield return new object[] { new int[] { -1 }, new int[] { -1 }, new int?[] { -1 } };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}