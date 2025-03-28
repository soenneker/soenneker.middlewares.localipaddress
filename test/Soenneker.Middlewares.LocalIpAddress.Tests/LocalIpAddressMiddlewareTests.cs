using Soenneker.Middlewares.LocalIpAddress.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Middlewares.LocalIpAddress.Tests;

[Collection("Collection")]
public class LocalIpAddressMiddlewareTests : FixturedUnitTest
{
    private readonly ILocalIpAddressMiddleware _util;

    public LocalIpAddressMiddlewareTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<ILocalIpAddressMiddleware>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
