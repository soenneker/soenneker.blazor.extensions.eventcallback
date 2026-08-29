[![](https://img.shields.io/nuget/v/soenneker.blazor.extensions.eventcallback.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.blazor.extensions.eventcallback/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.blazor.extensions.eventcallback/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.blazor.extensions.eventcallback/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.blazor.extensions.eventcallback.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.blazor.extensions.eventcallback/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.blazor.extensions.eventcallback/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.blazor.extensions.eventcallback/actions/workflows/codeql.yml)

# Soenneker.Blazor.Extensions.EventCallback

A collection of helpful Blazor EventCallback extension methods.

## Install

```bash
dotnet add package Soenneker.Blazor.Extensions.EventCallback
```

## Quick start

```csharp
using Soenneker.Blazor.Extensions.EventCallback;

EventCallback<T> callback = /* obtain from your application */;
await callback.InvokeIfHasDelegate(/* supply arg */ default!);
```

Asynchronously invokes the `EventCallback{T}` if it has been assigned a delegate and is not null.

## What you get

- `EventCallbackExtension` — A collection of helpful Blazor EventCallback extension methods.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `EventCallbackExtension.InvokeIfHasDelegate(callback, arg)` | Asynchronously invokes the `EventCallback{T}` if it has been assigned a delegate and is not null. | A `Task` representing the asynchronous operation. |
| `EventCallbackExtension.InvokeIfHasDelegate(callback)` | Invokes the specified `EventCallback` if it has a delegate assigned. | A `Task` representing the asynchronous operation. |

## Important behavior

- `EventCallbackExtension.InvokeIfHasDelegate(callback, arg)`: This method checks if the callback is not null and if it has a delegate assigned (using `EventCallback.HasDelegate`). It will invoke the delegate asynchronously, using the provided argument.
