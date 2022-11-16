using System.Web;

namespace WebTools.Models.EncodeDecode;

public class HtmlEncode : IEncodeDecodePageModel
{
    public string Name => "HtmlEncode";
    public string Description => "Converts a string into an HTML-encoded string.";
    public string? Input { get; set; }
    public string? Output { get; set; }
    public string? OutputType { get; set; }
    public void Encode()
    {
        Output = HttpUtility.HtmlEncode(Input);
        OutputType = IEncodeDecodePageModel.OutputTypeEncoded;
    }

    public void Decode()
    {
        Output = HttpUtility.HtmlDecode(Input);
        OutputType = IEncodeDecodePageModel.OutputTypeDecoded;
    }
}