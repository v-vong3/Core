using Core.Interfaces;
using Core.Models;
using Core.Seeding.Contracts;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Core.Seeding.Implementations
{
    /// <summary>
    /// Entry-point into running a seeding process
    /// </summary>
    public class Seeder : ISeeder
    {
        // TODO: Come to a final decision on if the Seeder can only process one strategy at a time to allow
        // caller to control continuation of pending strategy in the evident of an error result or should
        // SeedStrategy be a collection and the Seeder just aggregates all errors as it goes along
        public ISeedStrategy SeedStrategy { get; set; }

        public async Task<IResult> ExecuteAsync()
        {
            IResult result = await SeedStrategy.ExecuteAsync();

            return result;
        }

    }
}
