using FluentAssertions;
using ValidateStackSequencesAlgorithm;
using Xunit;

namespace ValidateStackSequencesTestSuit;
public class ValidateStackSequencesUnitTests
{
    public static IEnumerable<object[]> DataTestToBeTrue()
    {
        yield return new object[]
        {
            new int[] {1,2,3,4,5}, new int[] { 4, 5, 3, 2, 1 }
        };
    }

    public static IEnumerable<object[]> DataTestToBeFalse()
    {
        yield return new object[]
        {
            new int[] {1,2,3,4,5}, new int[] { 4, 3, 5, 1, 2 }
        };
    }

    [Theory]
    [MemberData(nameof(DataTestToBeTrue))]
    public void Validate_Deve_Ser_True(int[] pushed, int[] popped)
    {
        // Arrange, Act
        bool sutTrue = ValidateStackSequences.Validate(pushed, popped);

        // Assert
        sutTrue.Should().BeTrue();
    }

    [Theory]
    [MemberData(nameof(DataTestToBeFalse))]
    public void Validate_Deve_Ser_False(int[] pushed, int[] popped)
    {
        // Arrange, Act
        bool sut = ValidateStackSequences.Validate(pushed, popped);

        // Assert
        sut.Should().BeFalse();
    }


}
