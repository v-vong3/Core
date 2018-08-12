using Core.Interfaces;

namespace Core.Seeding.Contracts
{
    /// <summary>
    /// Contract for execution of a <see cref="ISeedStrategy"/>
    /// </summary>
    public interface ISeeder : ICommandAsync<IResult>
    {
        ISeedStrategy SeedStrategy { get; set; }


    }
}
