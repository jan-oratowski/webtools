using Microsoft.AspNetCore.Components;
using WebTools.Models;
using WebTools.Models.EncodeDecode;

namespace WebTools.Pages;

[Route("/encode-decode")]
[Route("/encode-decode/{algorithm}")]
public partial class EncodeDecode
{
    [Parameter]
    public string? Algorithm
    {
        set
        {
            switch (value)
            {
                case "rot13":
                    Model = new Rot13PageModel();
                    break;
                case "base64":
                    Model = new Base64PageModel();
                    break;
                case "url-encode":
                    Model = new UrlEncodePageModel();
                    break;
                case "html-encode":
                    Model = new HtmlEncode();
                    break;
                case "escape-data-string":
                    Model = new EscapeDataStringPageModel();
                    break;
                case "hex-escape":
                    Model = new HexEscapePageModel();
                    break;
                default:
                    break;
            }
        }
    }

    public IEncodeDecodePageModel? Model { get; set; }
}