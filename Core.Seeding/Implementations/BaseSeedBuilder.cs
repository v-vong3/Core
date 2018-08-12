using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Seeding.Contracts;

namespace Core.Seeding.Implementations
{
    /// <summary>
    /// Abstract base class for defining skeleton of <see cref="ISeedBuilder"/>
    /// Use this class for implementing a custom seed builder
    /// </summary>
    public abstract class BaseSeedBuilder : ISeedBuilder
    {
        // TODO: Test if using concurrent collection + Parallel.Invoke for inserts & deletes is better performance
        protected IList<ISeedDatum> Seeds { get; }

        public BaseSeedBuilder()
        {
            Seeds = new List<ISeedDatum>();
        }


        public ISeedBuilder Add(params ISeedDatum[] seedData)
        {
            // Early out if nothing to add
            if(seedData?.Length == 0)
            {
                return this;
            }

            foreach(var seed in seedData)
            {
                Seeds.Add(seed);
            }


            return this;
        }



        public ISeedBuilder Clear()
        {
            Seeds.Clear();

            return this;
        }

        public ISeedBuilder Remove(Type type)
        {
            var matches = Seeds.Where(s => s.ValueType == type);

            foreach(var match in matches)
            {
                Seeds.Remove(match);
            }

            return this;
        }

        public ISeedBuilder Remove(SeedDatumType datumType)
        {
            var matches = Seeds.Where(s => s.DatumType == datumType);

            foreach(var match in matches)
            {
                Seeds.Remove(match);
            }

            return this;
        }



        public Task<IOrderedEnumerable<ISeedDatum>> BuildAsync()
        {
            var sortedSeeds = Seeds.OrderBy(s => s.Order).ThenBy(s => s.DateAdded);

            return Task.FromResult(sortedSeeds);
        }
    }
}
