using Core.Seeding.Contract;
using Core.Seeding.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seeding
{
    public class SeedBuilder : ISeedBuilder
    {
        public ISeedBuilder Add(IEnumerable<object> data)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ISeedDatum>> BuildAsync()
        {
            throw new NotImplementedException();
        }

        public ISeedBuilder Clear()
        {
            throw new NotImplementedException();
        }

        public ISeedBuilder Remove(Type type)
        {
            throw new NotImplementedException();
        }
    }
}
