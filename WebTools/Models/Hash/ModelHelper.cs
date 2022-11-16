using System.Security.Cryptography;

namespace WebTools.Models.Hash;

public static class HashModelHelper
{
    public static GenericHashAlgorithmPageModel<SHA1> SHA1PageModel =>
        new(SHA1.Create());
    public static GenericHashAlgorithmPageModel<SHA256> SHA256PageModel =>
        new(SHA256.Create());
    public static GenericHashAlgorithmPageModel<SHA384> SHA384PageModel =>
        new(SHA384.Create());
    public static GenericHashAlgorithmPageModel<SHA512> SHA512PageModel =>
        new(SHA512.Create());
}