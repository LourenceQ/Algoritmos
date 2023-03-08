using _876MiddleOfTheLinkedListProj;

namespace xUnitTests;

public class UnitTest1
{
    public static IEnumerable<object[]> GetArgs()
    {
        yield return new object[]
        {
            new int[] {3,6,7,11}
            , 8, 4
        };
        yield return new object[]
        {
            new int[] {30,11,23,4,20}
            , 5, 30
        };
        yield return new object[]
        {
            new int[] {30,11,23,4,20}
            , 6, 23
        };
    }

    [Theory, MemberData(nameof(GetArgs))]
    public void Test1(int[] piles, int h, int output)
    {
        int res = Solution.MinEatingSpeed(piles, h);
        Assert.Equal(output, res);
    }
}