using FluentAssertions;
using ThreeSumAlgorithm;
using Xunit;

namespace ThreeSumTestSuit;


public class ThreeSumTests
{
    public class TestInput
    {
        public required int[] Input { get; set; }
        public int ExpectedCount { get; set; }
        public required List<IList<int>> ExpectedResults { get; set; }
    }

    public static TheoryData<TestInput> TestData()
    {
        return
        [
            new ()
            {
                Input = [ -1, 0, 1, 2, -1, -4 ]
                , ExpectedCount = 2
                , ExpectedResults = [[-1, -1, 2 ], [ -1, 0, 1 ]]
            },

            new ()
            {
                Input = [ 0, 1, 1 ]
                , ExpectedCount = 0
                , ExpectedResults = []
            },

            new() {
                Input = [0, 0, 0]
                , ExpectedCount = 1
                , ExpectedResults = [[0, 0, 0]]
            }
        ];
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void ThreeSum_ValidInput_ReturnsExpectedResult(TestInput testInput)
    {
        // Act
        var result = Program.ThreeSum(testInput.Input);

        // Assert
        result.Count.Should().Be(testInput.ExpectedCount);
        result.Should().BeEquivalentTo(testInput.ExpectedResults);
    }
}
