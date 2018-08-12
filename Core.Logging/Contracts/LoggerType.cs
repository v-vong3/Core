
namespace Core.Logging.Contracts
{
    /// <summary>
    /// Defines the valid types of loggers available
    /// </summary>
    public enum LoggerType
    {
        Null = 0,
        RDBMS = 1,
        NoSQL = 2,
        File = 3
    }
}
