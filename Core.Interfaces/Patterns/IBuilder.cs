using System.Threading.Tasks;

namespace Core.Interfaces.Patterns
{
    /// <summary>
    /// Contract for a synchronous Builder Pattern
    /// </summary>
    /// <typeparam name="T">The desired data type of the return value</typeparam>
    public interface IBuilder<T>
    {
        T Build();
    }

    /// <summary>
    /// Contract for an asynchronous Builder Pattern
    /// </summary>
    /// <typeparam name="T">The desired data type of the return value</typeparam>
    public interface IBuilderAsync<T>
    {
        Task<T> BuildAsync();
    }
}
