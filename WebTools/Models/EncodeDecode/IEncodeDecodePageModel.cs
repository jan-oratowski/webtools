namespace WebTools.Models.EncodeDecode
{
    public interface IEncodeDecodePageModel : IPageModel
    {
        const string OutputTypeDecoded = "Decoded";
        const string OutputTypeEncoded = "Encoded";

        string? Input { get; set; }
        string? Output { get; set; }
        string? OutputType { get; set; }
        void Encode();
        void Decode();
    }
}
