using _443StringCompressionProj;

namespace xUnitTests;

public class UnitTest1
{
    public static IEnumerable<object[]> GetArgs
    {
        get
        {
            yield return new object[]
        {
             new char[] { 'a','a','b','b','c','c','c' }
        };

        yield return new object[]
        {
             new char[] { 'a' }
        };

        yield return new object[]
        {
             new char[] { 'a','b','b','b','b','b','b','b','b','b','b','b','b' }
        };
        }
    }

    [Theory
    , MemberData(nameof(GetArgs))]
    public void CompressTest(char[] args)
    {
        var ans = Solution.Compress(args);
        Assert.Equal(6, ans);
        Assert.Equal(1, ans);
        Assert.Equal(4, ans);
    }
}