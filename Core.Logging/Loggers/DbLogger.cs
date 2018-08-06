using System;
using System.Data.Odbc;
using System.Threading.Tasks;

namespace Core.Logging.Loggers
{
    public class DbLogger : ILoggerAsync
    {
        private string _connStr;

        public DbLogger(string connectionString)
        {
            _connStr = connectionString;
        }

        public LoggerType Type => LoggerType.RDBMS;

        public Task<bool> LogAsync(LogLevel level, params string[] messages)
        {
            // TODO: Add database connection and data command code here

            throw new NotImplementedException();
        }
    }
}
