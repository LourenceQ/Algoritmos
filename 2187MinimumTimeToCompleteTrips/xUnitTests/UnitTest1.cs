using _2187MinimumTimeToCompleteTripsProj;

namespace _2187MinimumTimeToCompleteTripsUnitTests;

public class UnitTest1
{
    public static IEnumerable<object[]> GetArgs()
    {
        yield return new object[]
        {
            new int[] {1,2,3},5 ,3
        };
        yield return new object[]
        {
            new int[] {2}, 1, 2
        };
    }

    [Theory, MemberData(nameof(GetArgs))]
    public void MinimumTimeTest(int[] time, int totalTrips, int output)
    {
        long res = Solution.MinimumTime(time, totalTrips);
        Assert.Equal(output, res);
    }
}