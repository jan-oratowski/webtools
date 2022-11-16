using System.Web;

namespace WebTools.Models.EncodeDecode;

public class UrlEncodePageModel : IEncodeDecodePageModel
{
    public string Name => "UrlEncode";

    public string Description =>
        "Encodes a URL string. These method can be used to encode the entire URL, including query-string values.";
    public string? Input { get; set; }
    public string? Output { get; set; }
    public string? OutputType { get; set; }
    public void Encode()
    {
        Output = HttpUtility.UrlEncode(Input);
        OutputType = IEncodeDecodePageModel.OutputTypeEncoded;
    }

    public void Decode()
    {
        Output = HttpUtility.UrlDecode(Input);
        OutputType = IEncodeDecodePageModel.OutputTypeDecoded;
    }
}