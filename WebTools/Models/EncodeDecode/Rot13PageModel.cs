using Webtools.Core.Encoders;

namespace WebTools.Models.EncodeDecode
{
    public class Rot13PageModel : IPageModel, IEncodeDecodePageModel
    {
        public string Name => "Rot13";
        public string Description => "Rot13 is a simple obfuscation algorithm that shifts letters by 13 places.";
        
        public string? Input { get; set; }
        public string? Output { get; set; }
        public string? OutputType { get; set; }
        public void Encode()
        {
            if (string.IsNullOrEmpty(Input))
                return;

            Output = Rot13.Transform(Input);
            OutputType = "Encoded";
        }

        public void Decode()
        {
            if (string.IsNullOrEmpty(Input))
                return;

            Output = Rot13.Transform(Input);
            OutputType = "Decoded";
        }
    }
}
