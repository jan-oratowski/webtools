using System.Security.Cryptography;
using WebTools.Core.Hashes;

namespace WebTools.Models.Hash;

public class GenericHashAlgorithmPageModel<T> : IHashPageModel, IDisposable
    where T : HashAlgorithm, ICryptoTransform
{
    private readonly T _hasher;
    public GenericHashAlgorithmPageModel(T hasher, string? name = null, string? description = null)
    {
        _hasher = hasher;
        Name = name ?? nameof(_hasher);
        Description = description ?? string.Empty;
    }

    public string Name { get; }
    public string Description { get; }
    public bool UseBuffer { get; set; }
    public Stream? Input { get; set; }
    public string? Output { get; set; }

    public void Dispose()
    {
        _hasher.Dispose();
    }

    public async Task Hash()
    {
        if (Input == null)
        {
            Output = null;
            return;
        }

        Output = UseBuffer ?
            await _hasher.CalculateBuffered(Input) :
            await _hasher.Calculate(Input);
    }
}