using System.Security.Cryptography;
using Webtools.Core.Hashes;

namespace Webtools.Core.Tests.Hashes;

public class Sha384Tests
{
    private const string Data =
        @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non sodales neque sodales ut etiam sit amet nisl. Amet nulla facilisi morbi tempus iaculis urna. Vel fringilla est ullamcorper eget nulla facilisi etiam dignissim diam. Urna condimentum mattis pellentesque id nibh tortor id aliquet. Ac turpis egestas sed tempus urna et. Sed vulputate mi sit amet mauris commodo. Ut venenatis tellus in metus vulputate eu. Mauris ultrices eros in cursus turpis. Lectus sit amet est placerat in egestas erat imperdiet sed.
Odio eu feugiat pretium nibh. Odio eu feugiat pretium nibh ipsum consequat nisl vel. Cursus metus aliquam eleifend mi in nulla. Ut sem nulla pharetra diam sit. Faucibus ornare suspendisse sed nisi lacus sed viverra tellus in. Et leo duis ut diam quam nulla porttitor massa id. Suscipit tellus mauris a diam maecenas sed enim ut. Diam sit amet nisl suscipit adipiscing. Turpis massa sed elementum tempus. Orci nulla pellentesque dignissim enim sit amet venenatis urna cursus. Pellentesque id nibh tortor id.
Viverra accumsan in nisl nisi scelerisque eu ultrices. Mauris a diam maecenas sed enim ut sem viverra aliquet. Vel elit scelerisque mauris pellentesque pulvinar pellentesque habitant morbi. Sagittis id consectetur purus ut faucibus pulvinar. Scelerisque purus semper eget duis at tellus at. Eros in cursus turpis massa tincidunt dui ut ornare. Lacus viverra vitae congue eu consequat ac felis. Diam in arcu cursus euismod. Nec sagittis aliquam malesuada bibendum arcu vitae elementum. Cras semper auctor neque vitae tempus quam pellentesque. Ac tortor vitae purus faucibus ornare suspendisse sed. Mollis nunc sed id semper risus in. Auctor augue mauris augue neque gravida in. At consectetur lorem donec massa sapien faucibus et. Laoreet non curabitur gravida arcu ac tortor dignissim convallis aenean. Convallis a cras semper auctor. Eu tincidunt tortor aliquam nulla facilisi cras fermentum odio. Amet est placerat in egestas erat.
Proin nibh nisl condimentum id venenatis a condimentum vitae sapien. Ut tellus elementum sagittis vitae et leo duis ut diam. Morbi tincidunt ornare massa eget egestas purus. Ut enim blandit volutpat maecenas. Praesent semper feugiat nibh sed pulvinar. Dui nunc mattis enim ut tellus elementum sagittis vitae. Faucibus a pellentesque sit amet porttitor eget. Non arcu risus quis varius. Nec dui nunc mattis enim ut. Vitae congue mauris rhoncus aenean vel elit. Blandit turpis cursus in hac habitasse platea dictumst. Rutrum quisque non tellus orci ac auctor augue mauris augue. Bibendum arcu vitae elementum curabitur vitae nunc. Dictum varius duis at consectetur lorem donec. Urna duis convallis convallis tellus id interdum. Semper quis lectus nulla at volutpat diam ut venenatis tellus. Sit amet massa vitae tortor condimentum lacinia quis. Ac tincidunt vitae semper quis lectus nulla at volutpat. Cursus sit amet dictum sit amet. Urna duis convallis convallis tellus.
Nulla pellentesque dignissim enim sit amet. Mattis molestie a iaculis at erat. Dignissim enim sit amet venenatis urna cursus eget. Sollicitudin nibh sit amet commodo nulla. Nisl vel pretium lectus quam id leo in. Mi eget mauris pharetra et. Neque laoreet suspendisse interdum consectetur. Pellentesque habitant morbi tristique senectus et netus et. Sed nisi lacus sed viverra tellus in. Ipsum consequat nisl vel pretium lectus quam id leo in. Urna id volutpat lacus laoreet non curabitur gravida. Nisl tincidunt eget nullam non nisi est sit. Ut diam quam nulla porttitor massa. Facilisis mauris sit amet massa vitae tortor condimentum. Tortor pretium viverra suspendisse potenti nullam ac. Integer eget aliquet nibh praesent. Senectus et netus et malesuada fames ac. Velit egestas dui id ornare arcu odio ut. Neque volutpat ac tincidunt vitae semper quis lectus.";

    private const string ExpectedSha384 =
        "cb524fdcfa81a75234f841a7d5c969fb80373a45c1f0bd7c57101e94a4e5036285b23139a154d61ab18d2be2663a13a6";


    [Fact]
    public async Task Calculate()
    {
        var hasher = SHA384.Create();
        await using var stream = Data.ToStream();
        var hash = await hasher.Calculate(stream);
        Assert.Equal(ExpectedSha384, hash);
    }

    [Fact]
    public async Task CalculateSmallBuffer()
    {
        var hasher = SHA384.Create();
        await using var stream = Data.ToStream();
        var hash = await hasher.CalculateBuffered(stream, 2000);
        Assert.Equal(ExpectedSha384, hash);
    }

    [Fact]
    public async Task CalculateBigBuffer()
    {
        var hasher = SHA384.Create();
        await using var stream = Data.ToStream();
        var hash = await hasher.CalculateBuffered(stream, 200000);
        Assert.Equal(ExpectedSha384, hash);
    }
}