using System.Collections;

namespace XUnitTests.Models;

public class WindowsDataTest : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[]
        {
            new int[] {1,3,-1,-3,5,3,6,7}, 3, new int[] {3,3,5,5,6,7}
        };
        yield return new object[] 
        {
            new int[] {1,7,-1,-3,5,7,6,7}, 4, new int[] {7,7,7,7,7}
        };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}