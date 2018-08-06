using Core.Interfaces;
using Core.Seeding.Contract;
using System;
using System.Collections.Generic;

namespace Core.Seeding.Contracts
{
    public interface ISeeder<T> : ICommandAsync<T>
    {
        IEnumerable<ISeedDatum> SeedData { get; }

        ISeederContext SeederContext { get; }
    }
}
