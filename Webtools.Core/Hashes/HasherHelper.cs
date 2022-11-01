using System.Security.Cryptography;
using System.Text;

namespace Webtools.Core.Hashes
{
    /// <summary>
    /// Helper class for calculating hashes
    /// In Blazor WebAssembly supports:
    /// SHA1, SHA256, SHA384, and SHA512.
    /// </summary>
    public static class HasherHelper
    {
        public static async Task<string> Calculate<T>(this T algorithm, Stream stream)
            where T : HashAlgorithm, ICryptoTransform
        {
            algorithm.Initialize();

            var hash = await algorithm.ComputeHashAsync(stream);

            var sBuilder = new StringBuilder();
            foreach (var t in hash)
                sBuilder.Append(t.ToString("x2"));

            return sBuilder.ToString();
        }

        /// <summary>
        /// Uses buffer to speed up the computation and avoid OutOfMemory problems.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="algorithm"></param>
        /// <param name="stream"></param>
        /// <param name="bufferLength"></param>
        /// <returns></returns>
        public static async Task<string> CalculateBuffered<T>(this T algorithm, Stream stream, int bufferLength = 2000000)
            where T : HashAlgorithm, ICryptoTransform
        {
            var buffer = new byte[bufferLength];

            algorithm.Initialize();
            
            while (true)
            {
                if (stream.Position + bufferLength > stream.Length)
                {
                    var endBuffer = new byte[stream.Length - stream.Position];
                    _ = await stream.ReadAsync(endBuffer, 0, endBuffer.Length);
                    algorithm.TransformFinalBlock(endBuffer, 0, endBuffer.Length);

                    var hash = algorithm.Hash;

                    var sBuilder = new StringBuilder();
                    foreach (var t in hash!)
                        sBuilder.Append(t.ToString("x2"));

                    return sBuilder.ToString();
                }

                _ = await stream.ReadAsync(buffer, 0, buffer.Length);
                algorithm.TransformBlock(buffer, 0, bufferLength, null, 0);
            }
        }
    }
}
