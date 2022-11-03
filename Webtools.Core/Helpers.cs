using System.Text;

namespace WebTools.Core
{
    public static class Helpers
    {
        public static Stream ToStream(this string fromString, Encoding? encoding = null)
        {
            encoding ??= Encoding.UTF8;
            var bytes = encoding.GetBytes(fromString);
            return new MemoryStream(bytes);
        }
    }
}