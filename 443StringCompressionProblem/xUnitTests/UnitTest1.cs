using _443StringCompressionProj;

namespace xUnitTests;

public class UnitTest1
{
    public static IEnumerable<object[]> GetArgs()
    {
        yield return new object[] 
        { 
            new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' }
            , new char[] { 'a', '2', 'b', '2', 'c', '3' }, 6 
        };
        yield return new object[] 
        { 
            new char[] { 'a' }
            , new char[] { 'a' }, 1 
        };
        yield return new object[] 
        { 
            new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' }
            , new char[] { 'a', 'b', '1', '2' }, 4 
        };
    
    }

    [Theory
    , MemberData(nameof(GetArgs))]
    public void CompressTest(char[] input, char[] expectedOutput, int expectedLength)
    {
        var actualLength  = Solution.Compress(input);
        Assert.Equal(expectedLength, actualLength );
        Assert.Equal(expectedOutput, input[..actualLength ]);
    }
}