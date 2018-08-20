using Core.Interfaces;
using Core.Models;
using Core.Seeding.Contracts;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Seeding.Implementations
{

    /// <summary>
    /// Abstract class for the skeleton of an enhanced version of <see cref="BaseSeeder"/> that
    /// allows for the invocation of multiple strategies
    /// </summary>
    public abstract class BaseSeederEx : ISeederEx
    {
        // DESIGN: Strategy order matters and all strategies are invoked no matter the result (success or otherwise),
        // thus, the final result is the aggregate of all individual strategy result
        public IOrderedEnumerable<ISeedStrategy> SeedStrategies { get;  }

        public virtual async Task<IAggregateResult> ExecuteAsync()
        {
            var aggregateResult = new AggregateResult(); 

            foreach(var ss in SeedStrategies)
            {
                var result = await ss.ExecuteAsync().ConfigureAwait(false);

                aggregateResult.Results.Add(result);
            }

            return aggregateResult;
        }
    }
}
