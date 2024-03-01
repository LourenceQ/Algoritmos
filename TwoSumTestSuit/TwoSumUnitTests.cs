using FluentAssertions;
using TwoSumAlgorithm;
using Xunit;

namespace TwoSumTestSuit;

public class TwoSumUnitTests
{
    public static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1}
        };

        yield return new object[]
        {
            new int[] { 3,2,4 }, 6, new int[] { 1, 2}
        };
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public static void Two_Sum_Deve_Retornar_True(int[] nums, int target, int[] output)
    {
        // Arrange, Act
        int[] sut = TwoSum.Validate(nums, target);

        // Assert
        sut.Should().Equal(output);
    }
}
