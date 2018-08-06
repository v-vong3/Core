using System;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    /// <summary>
    /// Contract for a synchronous Command Pattern
    /// </summary>
    /// <typeparam name="T">The desired data type of the return value</typeparam>
    public interface ICommand<T>
    {
        T Execute();
    }

    /// <summary>
    /// Contract for an asynchronous Command Pattern
    /// </summary>
    /// <typeparam name="T">The desired data type of the return value</typeparam>
    public interface ICommandAsync<T>
    {
        // DESIGN: 
        // Fire & forget asynchronous calls like event emissions typically does not require a 
        // return type, but the vast majority of other scenarios do, therefore, requiring
        // implementations to provide a non-void return type
        Task<T> ExecuteAsync();
    }
}
