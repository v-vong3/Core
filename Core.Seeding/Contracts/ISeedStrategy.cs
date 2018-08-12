using Core.Interfaces;

namespace Core.Seeding.Contracts
{
    /// <summary>
    /// Contract for the implementation logic of the seeding process within 
    /// the specific scope (e.g. database, file, etc.)
    /// </summary>
    /// <remarks>
    /// Third party dependencies should be isolated to the concrete implementations of this interface
    /// </remarks>
    public interface ISeedStrategy : IStrategyAsync
    {

    }
}
