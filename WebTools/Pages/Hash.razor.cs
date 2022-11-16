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
                    Model = new StandardShaPageModel<SHA1>();
                    break;
                case "sha256":
                    Model = new StandardShaPageModel<SHA256>();
                    break;
                case "sha384":
                    Model = new StandardShaPageModel<SHA384>();
                    break;
                case "sha512":
                    Model = new StandardShaPageModel<SHA512>();
                    break;
                default:
                    break;
            }
        }
    }

    public IHashPageModel? Model { get; set; }
}