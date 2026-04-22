using Soenneker.Tests.HostedUnit;

namespace Soenneker.Blazor.Extensions.EventCallback.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class EventCallbackExtensionTests : HostedUnitTest
{
    public EventCallbackExtensionTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
