using System.Collections;

namespace XUnitTests;

public class DataTests : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { "abcabcabc", true };

        yield return new object[] {"acbdabcabcaef", false};

        yield return new object[] {"abjiruoabjiruo", true};
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}