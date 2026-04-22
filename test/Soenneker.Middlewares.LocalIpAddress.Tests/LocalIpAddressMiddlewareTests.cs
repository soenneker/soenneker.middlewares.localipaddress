using Soenneker.Tests.HostedUnit;

namespace Soenneker.Middlewares.LocalIpAddress.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class LocalIpAddressMiddlewareTests : HostedUnitTest
{
    public LocalIpAddressMiddlewareTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
