using WebTools.Core.Encoders;

namespace WebTools.Models.EncodeDecode;

public class HexEscapePageModel : IEncodeDecodePageModel
{
    public string Name => "Hex Escape";
    public string Description => "Converts characters into their hexadecimal equivalent.";
    public string? Input { get; set; }
    public string? Output { get; set; }
    public string? OutputType { get; set; }
    public void Encode()
    {
        Output = HexEscape.Escape(Input);
        OutputType = IEncodeDecodePageModel.OutputTypeEncoded;
    }

    public void Decode()
    {
        Output = HexEscape.UnEscape(Input);
        OutputType = IEncodeDecodePageModel.OutputTypeDecoded;
    }
}