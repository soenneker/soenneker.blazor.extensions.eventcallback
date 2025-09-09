using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Soenneker.Blazor.Extensions.EventCallback;

/// <summary>
/// A collection of helpful Blazor EventCallback extension methods
/// </summary>
public static class EventCallbackExtension
{
    /// <summary>
    /// Asynchronously invokes the <see cref="EventCallback{T}"/> if it has been assigned a delegate and is not null.
    /// </summary>
    /// <typeparam name="T">The type of the argument passed to the <see cref="EventCallback{T}"/>.</typeparam>
    /// <param name="callback">The <see cref="EventCallback{T}"/> to invoke, which may be null.</param>
    /// <param name="arg">The argument to pass to the callback when invoked.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    /// <remarks>
    /// This method checks if the callback is not null and if it has a delegate assigned (using <see cref="EventCallback.HasDelegate"/>).
    /// It will invoke the delegate asynchronously, using the provided argument.
    /// </remarks>
    public static Task InvokeIfHasDelegate<T>(this EventCallback<T> callback, T? arg)
    {
        return callback.HasDelegate ? callback.InvokeAsync(arg) : Task.CompletedTask;
    }

    /// <summary>
    /// Invokes the specified <see cref="EventCallback"/> if it has a delegate assigned.
    /// </summary>
    /// <param name="callback">The <see cref="EventCallback"/> to invoke.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    public static Task InvokeIfHasDelegate(this Microsoft.AspNetCore.Components.EventCallback callback)
    {
        return callback.HasDelegate ? callback.InvokeAsync() : Task.CompletedTask;
    }
}
