using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Logging.Loggers
{
    public class NullLogger : ILoggerAsync
    {
        public NullLogger() { }

        public LoggerType Type => LoggerType.Null;

        public Task<bool> LogAsync(LogLevel level = LogLevel.Null, params string[] messages)
        {
            throw new NotImplementedException();
        }
    }

}
