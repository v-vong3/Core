using Core.Logging.Contracts;
using System.Data.Odbc;
using System.Threading.Tasks;

namespace Core.Logging.Implementations
{
    public class SqlLogger : ILoggerAsync<bool>
    {
        private string ConnectionString { get; }

        public SqlLogger(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public LoggerType Type => LoggerType.RDBMS;

        public async Task<bool> LogAsync(LogLevel level, params string[] messages)
        {

            // DESIGN: Using OdbcConnection instead of SqlConnection as it is the standard
            // RDBMS driver.  SqlConnection is more performant, but it is specific to SQL Server

            using (var connection = new OdbcConnection(ConnectionString))
            {
                var sql = string.Empty; // TODO: YOUR implementation code HERE

                using (var command = new OdbcCommand(sql))
                {
                    command.Connection = connection;
                    connection.Open();
                    var rowsAffected = await command.ExecuteNonQueryAsync().ConfigureAwait(false);

                    if(rowsAffected > 0)
                    {
                        return true;
                    }

                    return false;
                }
            }
        }
    }
}
