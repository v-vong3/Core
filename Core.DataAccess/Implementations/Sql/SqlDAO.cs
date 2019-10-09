using Core.DataAccess.Contracts;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public class SqlDAO : IDataStoreConnection, ISqlDAOAsync
    {
        private SqlClientFactory _sqlClientFactory;

        #region IDataStoreConnection
        public Task<bool> OpenConnection(string connString)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> CloseConnection()
        {
            throw new System.NotImplementedException();
        }
        #endregion


        #region ISqlDAO
        public int ExecuteAsync(string sql)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> Query<T>(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
