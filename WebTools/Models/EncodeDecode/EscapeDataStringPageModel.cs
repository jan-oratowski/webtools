namespace WebTools.Models.EncodeDecode;

public class EscapeDataStringPageModel : IEncodeDecodePageModel
{
    public string Name => "Escape Data String";
    public string Description => "Encodes special characters in the input data according to the rules of RFC 3986.";
    public string? Input { get; set; }
    public string? Output { get; set; }
    public string? OutputType { get; set; }
    public void Encode()
    {
        Output = Uri.EscapeDataString(Input ?? string.Empty);
        OutputType = IEncodeDecodePageModel.OutputTypeEncoded;
    }

    public void Decode()
    {
        Output = Uri.UnescapeDataString(Input ?? string.Empty);
        OutputType = IEncodeDecodePageModel.OutputTypeDecoded;
    }
}