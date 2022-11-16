using System.Security.Cryptography;
using WebTools.Models.Hash;

namespace WebTools.Pages

[Route("/hash")]
[Route("/hash/{algorithm}")]
public partial class Hash
{
    [Parameter]
    public string? Algorithm
    {
        set
        {
            switch (value)
            {
                case "sha1":
                    Model = ModelHelper.SHA1PageModel;
                    break;
                case "sha256":
                    Model = ModelHelper.SHA256PageModel;
                    break;
                case "sha384":
                    Model = ModelHelper.SHA384PageModel;
                    break;
                case "sha512":
                    Model = ModelHelper.SHA512PageModel;
                    break;
                default:
                    break;
            }
        }
    }

    public IHashPageModel? Model { get; set; }
}