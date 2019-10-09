using System.Threading.Tasks;

namespace Core.DataAccess.Contracts
{
    public interface IDataStoreConnection
    {
        Task<bool> OpenConnection(string connString);


        Task<bool> CloseConnection();

    }
}
