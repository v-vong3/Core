using Core.Seeding.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Seeding.Implementations
{
    /// <summary>
    /// Abstract base class for defining skeleton of <see cref="ISeedBuilder"/>
    /// Use this class for implementing a custom seed builder
    /// </summary>
    public abstract class BaseSeedBuilder : ISeedBuilder
    {
        // TODO: Test if using a concurrent collection + Parallel.Invoke for inserts & deletes is better performance
        protected ICollection<ISeedDatum> Seeds { get; }

        public BaseSeedBuilder()
        {
            Seeds = new List<ISeedDatum>();
        }


        public virtual ISeedBuilder Add(params ISeedDatum[] seedData)
        {
            if (seedData?.Length > 0)
            {
                foreach (var seed in seedData)
                {
                    Seeds.Add(seed);
                }
            }

            return this;
        }



        public virtual ISeedBuilder Clear()
        {
            Seeds.Clear();

            return this;
        }

        public virtual ISeedBuilder Remove(Type type)
        {
            var matches = Seeds.Where(s => s.ValueType == type);

            foreach (var match in matches)
            {
                Seeds.Remove(match);
            }

            return this;
        }

        public virtual ISeedBuilder Remove(SeedDatumType datumType)
        {
            var matches = Seeds.Where(s => s.DatumType == datumType);

            foreach (var match in matches)
            {
                Seeds.Remove(match);
            }

            return this;
        }



        public virtual Task<IOrderedEnumerable<ISeedDatum>> BuildAsync()
        {
            var sortedSeeds = Seeds.OrderBy(s => s.Order)
                                   .ThenBy(s => s.DateAdded);

            return Task.FromResult(sortedSeeds);
        }
    }
}
