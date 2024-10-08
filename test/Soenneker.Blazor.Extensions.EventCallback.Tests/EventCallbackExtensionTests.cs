using Soenneker.Tests.FixturedUnit;
using Xunit;
using Xunit.Abstractions;

namespace Soenneker.Blazor.Extensions.EventCallback.Tests;

[Collection("Collection")]
public class EventCallbackExtensionTests : FixturedUnitTest
{
    public EventCallbackExtensionTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }
}
