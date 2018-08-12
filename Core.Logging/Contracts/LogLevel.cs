
namespace Core.Logging.Contracts
{
    /// <summary>
    /// Defines all valid log message category 
    /// </summary>
    public enum LogLevel
    {
        Null = 0, // Log message will be a no-operation (NOOP)
        Debug,
        Info,
        Warning,
        Error,
        Critical
    }
}
