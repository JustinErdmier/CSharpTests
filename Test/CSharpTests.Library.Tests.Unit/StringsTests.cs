namespace CSharpTests.Library.Tests.Unit;

public class StringsTests
{
    private readonly Strings _sut = new ();

    [ Fact ]
    public void NonNullableDefaultString_ShouldBeSet_WhenInstantiated()
    {
        // Arrange
        const string expected = default!;

        // Act
        string actual = _sut.NonNullableDefaultString;

        // Assert
        actual.Should().Be(expected);
    }

    [ Fact ]
    public void NonNullableDefaultString_ShouldBeNotBeEquivalentToEmptyString_WhenInstantiated()
    {
        // Arrange
        const string expected = "";

        // Act
        string actual = _sut.NonNullableDefaultString;

        // Assert
        actual.Should().NotBeEquivalentTo(expected);
    }

    [ Fact ]
    public void NonNullableDefaultString_ShouldBeEquivalentToNull_WhenInstantiated()
    {
        // Arrange
        const string? expected = null;

        // Act
        string actual = _sut.NonNullableDefaultString;

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }

    [ Fact ]
    public void NullableDefaultString_ShouldBeSet_WhenInstantiated()
    {
        // Arrange
        const string expected = default;

        // Act
        string? actual = _sut.NullableDefaultString;

        // Assert
        actual.Should().Be(expected);
    }
}
