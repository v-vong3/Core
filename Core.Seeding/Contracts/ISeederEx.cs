using Core.Interfaces;
using Core.Interfaces.Patterns;
using System.Linq;

namespace Core.Seeding.Contracts
{
    /// <summary>
    /// Contract for enhanced <see cref="ISeeder"/> that allows for the execution of multiple <see cref="ISeedStrategy"/>
    /// </summary>
    public interface ISeederEx : ICommandAsync<IAggregateResult>
    {
        IOrderedEnumerable<ISeedStrategy> SeedStrategies { get; }
    }
}
