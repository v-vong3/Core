
using Core.Logging.Contracts;
using System.Threading.Tasks;

namespace Core.Logging.Implementations
{
    /// <summary>
    /// NOOP logger
    /// </summary>
    public class NullLogger : ILoggerAsync
    {
        public NullLogger() { }

        public LoggerType Type => LoggerType.Null;


        public Task LogAsync(LogLevel level, params string[] messages)
        {
            return Task.FromResult(true); // Always returns successful operation
        }


    }

}
