using Soenneker.Tests.HostedUnit;

namespace Soenneker.Telnyx.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class TelnyxOpenApiClientTests : HostedUnitTest
{
    public TelnyxOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
