
namespace Core.Interfaces.Patterns
{
    /// <summary>
    /// Contract for a synchronous Factory Pattern
    /// </summary>
    /// <typeparam name="T">The desired data type of the return value</typeparam>
    public interface IFactory<T>
    {
        T CreateInstance(string type);
    }

    /// <summary>
    /// Contract for an asynchronous Factory Pattern
    /// </summary>
    /// <typeparam name="T">The desired data type of the return value</typeparam>
    public interface IFactoryAsync<T>
    {
        T CreateInstanceAsync(string type);
    }

}
