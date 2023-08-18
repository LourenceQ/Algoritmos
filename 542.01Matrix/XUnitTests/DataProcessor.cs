using System.Collections;

namespace XUnitTests;

public class MatrixTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[]
        {
            new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 1, 1, 1 },
            },
            new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 1, 2, 1 },
            }
        };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}