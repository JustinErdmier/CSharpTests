namespace CSharpTests.Library;

public sealed class Strings
{
    /// <summary>
    ///     An auto-property of type <see langword="string" /> that is non-nullable and set with the
    ///     <see langword="default" /> keyword with a the null-forgiving operator.
    /// </summary>
    public string NonNullableDefaultString { get; set; } = default!;

    /// <summary>
    ///     An auto-property of type <see langword="string" /> that is nullable and set with the
    ///     <see langword="default" /> keyword.
    /// </summary>
    public string? NullableDefaultString { get; set; } = default;
}
