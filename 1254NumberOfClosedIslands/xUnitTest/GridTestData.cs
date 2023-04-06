using System.Collections;

namespace _1254NumberOfClosedIslandsTests;

public class GridTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { new int[][] { new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 0, 0, 0, 1 }, new int[] { 1, 0, 1, 0, 1 }, new int[] { 1, 0, 0, 0, 1 }, new int[] { 1, 1, 1, 1, 1 } }, 1 };
        yield return new object[] { new int[][] { new int[] { 0, 0, 1, 0, 0 }, new int[] { 0, 1, 0, 1, 0 }, new int[] { 0, 1, 1, 1, 0 } }, 2 };
        yield return new object[] { new int[][] { new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 0, 0, 0, 1 }, new int[] { 1, 0, 1, 0, 1 }, new int[] { 1, 0, 0, 1, 1 }, new int[] { 1, 1, 1, 1, 1 } }, 0 };
        // add more test cases here
    }

    IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}