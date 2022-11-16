using WebTools.Core.Encoders;

namespace WebTools.Core.Tests.Encoders;

public class HexEscapeTest
{
    [Theory]
    [InlineData(null, "")]
    [InlineData("A", "%41")]
    [InlineData("Aa", "%41%61")]
    public void TestEscape(string? input, string expected)
    {
        var output = HexEscape.Escape(input);
        Assert.Equal(output, expected);
    }

    [Theory]
    [InlineData(null, "")]
    [InlineData("%41", "A")]
    [InlineData("%41%61", "Aa")]
    public void TestUnEscape(string? input, string expected)
    {
        var output = HexEscape.UnEscape(input);
        Assert.Equal(output, expected);
    }
}