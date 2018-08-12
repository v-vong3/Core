
using System.Threading.Tasks;

namespace Core.Logging.Contracts
{
    /// <summary>
    /// Contract for a synchronous logger component
    /// </summary>
    public interface ILogger
    {
        LoggerType Type { get; }

        // DESIGN:
        // void return type dictates that the concrete method implementation is solely responsible
        // for handling all errors that arise during logging
        void Log(LogLevel level, params string[] messages);
    }

    /// <summary>
    /// Contract for a synchronous logger component
    /// </summary>
    public interface ILogger<T>
    {
        LoggerType Type { get; }

        T Log(LogLevel level, params string[] messages);
    }


    /// <summary>
    /// Contract for an asynchronous logging feature
    /// </summary>
    public interface ILoggerAsync
    {
        LoggerType Type { get; }

        Task LogAsync(LogLevel level, params string[] messages);
    }

    /// <summary>
    /// Contract for an asynchronous logging feature
    /// </summary>
    public interface ILoggerAsync<T>
    {
        LoggerType Type { get; }

        Task<T> LogAsync(LogLevel level, params string[] messages);
    }





}
