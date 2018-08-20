using Core.Exceptions;
using Core.Interfaces;
using Core.Seeding.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seeding.Implementations
{
    /// <summary>
    /// Abstract base class for defining a seeding strategy (i.e. the actual seeding logic and control flow)
    /// </summary>
    public abstract class BaseSeedStrategy : ISeedStrategy
    {
        public string Name { get; }
        public IOrderedEnumerable<ISeedDatum> SeedData { get; }

        public BaseSeedStrategy(IOrderedEnumerable<ISeedDatum> seedData, string name)
        {
            Guard.AgainstNullArgument(seedData, nameof(seedData));
            Guard.AgainstNullArgument(name, nameof(name));

            SeedData = seedData;
            Name = name;
        }

        public abstract Task<IResult> ExecuteAsync();
    }
}
