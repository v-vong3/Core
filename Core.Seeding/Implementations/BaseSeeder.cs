using Core.Interfaces;
using Core.Seeding.Contracts;
using System.Threading.Tasks;

namespace Core.Seeding.Implementations
{
    /// <summary>
    /// Abstract class for the skeleton of a seeding process's entry point (i.e. the trigger for running seeding process)
    /// </summary>
    public abstract class BaseSeeder : ISeeder
    {
        // DESIGN: The caller of this class dictates how to proceed once result (success or otherwise) is achieved
        public ISeedStrategy SeedStrategy { get; set; }

        public virtual async Task<IResult> ExecuteAsync()
        {
            return await SeedStrategy.ExecuteAsync().ConfigureAwait(false);
        }

    }


}
