using WebTools.Core.Encoders;

namespace WebTools.Core.Tests.Encoders
{
    public class Rot13Tests
    {
        private const string Value1 = "There was a cute dog in 2008. (Zamborine)";
        private const string Value2 = "Gurer jnf n phgr qbt va 2008. (Mnzobevar)";

        [Theory]
        [InlineData(Value1,Value2)]
        [InlineData(Value2,Value1)]
        public void Transform(string input, string expected)
        {
            var output = Rot13.Transform(input);
            Assert.Equal(output, expected);
        }
    }
}
