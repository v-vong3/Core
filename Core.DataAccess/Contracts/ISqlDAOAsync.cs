using System;
using System.Collections.Generic;

namespace Core.DataAccess.Contracts
{
    public interface ISqlDAOAsync
    {
        int ExecuteAsync(string sql);

        ICollection<T> Query<T>(Func<T, bool> predicate);
    }
}
