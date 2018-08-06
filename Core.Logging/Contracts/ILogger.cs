using System;
using System.Threading.Tasks;

namespace Core.Logging
{
    /// <summary>
    /// Contract for a synchronous logging feature
    /// </summary>
    public interface ILogger
    {
        LoggerType Type { get; }

        // DESIGN:
        // void return type dictates that the concrete method implementation is responsible
        // for all error handling and not the caller
        void Log(LogLevel level, params string[] messages);
    }

    /// <summary>
    /// Contract for an asynchronous logging feature
    /// </summary>
    public interface ILoggerAsync
    {
        LoggerType Type { get; }

        Task<bool> LogAsync(LogLevel level, params string[] messages);
    }


    
}
