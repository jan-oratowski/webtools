using Microsoft.AspNetCore.Components;
using WebTools.Models.EncodeDecode;

namespace WebTools.Pages;

[Route("/encode-decode")]
[Route("/encode-decode/{algo}")]
public partial class EncodeDecode
{
    [Parameter]
    public string? Algo
    {
        set
        {
            switch (value)
            {
                case "rot13":
                    Model = new Rot13PageModel();
                    break;
                default:
                    break;
            }
        }
    }

    public IEncodeDecodePageModel? Model { get; set; }
}