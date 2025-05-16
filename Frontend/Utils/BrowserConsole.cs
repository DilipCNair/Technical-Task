namespace Frontend.Utils;

using Microsoft.JSInterop;
using System.Threading.Tasks;

public class BrowserConsole(IJSRuntime jsRuntime)
{
    /// <summary>
    /// Logs a message to the browser console.
    /// </summary>
    /// <param name="message">The message to log.</param>
    public async Task Log(string message)
    {
        await jsRuntime.InvokeVoidAsync("console.log", message);
    }

    /// <summary>
    /// Logs an error message to the browser console.
    /// </summary>
    /// <param name="message">The error message to log.</param>
    public async Task Error(string message)
    {
        await jsRuntime.InvokeVoidAsync("console.error", message);
    }

    /// <summary>
    /// Logs a warning message to the browser console.
    /// </summary>
    /// <param name="message">The error message to log.</param>
    public async Task Warn(string message)
    {
        await jsRuntime.InvokeVoidAsync("console.warn", message);
    }

    /// <summary>
    /// Logs an info message to the browser console.
    /// </summary>
    /// <param name="message">The error message to log.</param>
    public async Task Info(string message)
    {
        await jsRuntime.InvokeVoidAsync("console.info", message);
    }

    /// <summary>
    /// Logs a debug message to the browser console.
    /// </summary>
    /// <param name="message">The error message to log.</param>
    public async Task Debug(string message)
    {
        await jsRuntime.InvokeVoidAsync("console.debug", message);
    }
}

