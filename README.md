[![](https://img.shields.io/nuget/v/soenneker.blazor.extensions.eventcallback.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.blazor.extensions.eventcallback/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.blazor.extensions.eventcallback/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.blazor.extensions.eventcallback/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.blazor.extensions.eventcallback.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.blazor.extensions.eventcallback/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.blazor.extensions.eventcallback/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.blazor.extensions.eventcallback/actions/workflows/codeql.yml)

# Soenneker.Blazor.Extensions.EventCallback

Small Blazor extensions that invoke an `EventCallback` only when its consumer assigned a delegate.

## Installation

```bash
dotnet add package Soenneker.Blazor.Extensions.EventCallback
```

## Usage

The extension removes repeated `HasDelegate` checks from reusable components:

```razor
@using Soenneker.Blazor.Extensions.EventCallback

<button @onclick="Save">Save</button>

@code {
    [Parameter]
    public EventCallback<Order> OnSaved { get; set; }

    private async Task Save()
    {
        Order order = await SaveOrder();
        await OnSaved.InvokeIfHasDelegate(order);
    }
}
```

The non-generic overload works the same way:

```csharp
[Parameter]
public EventCallback OnClosed { get; set; }

await OnClosed.InvokeIfHasDelegate();
```

When no delegate is assigned, both overloads return `Task.CompletedTask`. When a delegate is assigned, invocation follows normal Blazor `EventCallback.InvokeAsync` behavior, including renderer dispatch and exception propagation. Await the returned task when subsequent work depends on the callback completing.
