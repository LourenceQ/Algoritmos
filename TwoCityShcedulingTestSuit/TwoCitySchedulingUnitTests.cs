using AutoFixture;
using FluentAssertions;
using TwoCitySchedulingAlgorithm;
using Xunit;

namespace TwoCityShcedulingTestSuit;
public class TwoCitySchedulingUnitTests
{
    public static IEnumerable<object[]> TestData =>
    [
        [new int[][] { [10, 20], [30, 200], [400, 50], [30, 20] }, 110],
        [new int[][] { [259, 770], [448, 54], [926, 667], [184, 139], [840, 118], [577, 469] }, 1859],
        [new int[][] { [515, 563], [451, 713], [537, 709], [343, 819], [855, 779], [457, 60], [650, 359], [631, 42] }, 3086]
    ];

    [Theory]
    [MemberData(nameof(TestData))]
    public void TwoCityScheduling_Deve_Retornar_True(int[][] inputData, int expectedResult)
    {
        // Arrange
        int[][] data = new Fixture().Create<int[][]>();

        // Act
        var sut = TwoCityScheduling.Validate(inputData);

        // Assert        
        sut.Should().Be(expectedResult);
    }

}
