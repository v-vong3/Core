using Core.Interfaces;
using Core.Interfaces.Patterns;

namespace Core.Logging.Contracts
{
    /// <summary>
    /// Contract for implementing the Factory Pattern for the creation of <see cref="ILogger"/> objects
    /// </summary>
    public interface ILoggerFactory : IFactory<ILoggerAsync>
    { }
}
