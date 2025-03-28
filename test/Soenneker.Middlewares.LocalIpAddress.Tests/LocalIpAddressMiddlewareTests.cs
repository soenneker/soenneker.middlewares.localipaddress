using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Middlewares.LocalIpAddress.Tests;

[Collection("Collection")]
public class LocalIpAddressMiddlewareTests : FixturedUnitTest
{
    public LocalIpAddressMiddlewareTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
