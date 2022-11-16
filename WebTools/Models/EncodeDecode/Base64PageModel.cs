using System.Text;

namespace WebTools.Models.EncodeDecode;

public class Base64PageModel : IEncodeDecodePageModel
{
    public string Name => "Base64";

    public string Description =>
        "Base64 is an encoding method, where any data (text or binary) will be replaced by a string of alphanumeric characters.";
        
    public string? Input { get; set; }
    public string? Output { get; set; }
    public string? OutputType { get; set; }
    public void Encode()
    {
        var bytes = Encoding.UTF8.GetBytes(Input ?? string.Empty);
        Output = Convert.ToBase64String(bytes);
        OutputType = IEncodeDecodePageModel.OutputTypeEncoded;
    }

    public void Decode()
    {
        var base64 = Convert.FromBase64String(Input ?? string.Empty);
        Output = Encoding.UTF8.GetString(base64);
        OutputType = IEncodeDecodePageModel.OutputTypeDecoded;
    }
}