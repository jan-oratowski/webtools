namespace WebTools.Models.EncodeDecode
{
    public interface IEncodeDecodePageModel : IPageModel
    {
        string? Input { get; set; }
        string? Output { get; set; }
        string? OutputType { get; set; }
        void Encode();
        void Decode();
    }
}
