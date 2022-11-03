using System.Security.Cryptography;
using WebTools.Core;
using WebTools.Core.Hashes;

namespace WebTools.Models.Hash
{
    public class StandardShaPageModel<T> : IHashPageModel
        where T : HashAlgorithm, ICryptoTransform, new()
    {
        public string Name { get; }
        public string Description { get; }
        public bool UseBuffer { get; set; }
        public Stream? Input { get; set; }
        public string? Output { get; set; }
        public async Task Hash()
        {
            if (Input == null)
            {
                Output = null;
                return;
            }
            
            using var hash = new T();
            Output = UseBuffer ?
                await hash.CalculateBuffered(Input) :
                await hash.Calculate(Input);
        }
    }
}
