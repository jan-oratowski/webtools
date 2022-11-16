using System.Text;

namespace WebTools.Core.Encoders;

public static class HexEscape
{
    public static string Escape(string? s)
    {
        var sb = new StringBuilder();
        foreach (var chr in (s ?? string.Empty).ToCharArray())
            sb.Append(Uri.HexEscape(chr));

        return sb.ToString();
    }

    public static string UnEscape(string? s)
    {
        s ??= string.Empty;
        var sb = new StringBuilder();
        for (var pos = 0; pos < s.Length;)
            sb.Append(Uri.HexUnescape(s, ref pos));

        return sb.ToString();
    }
}