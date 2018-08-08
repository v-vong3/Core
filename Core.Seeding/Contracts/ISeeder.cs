using Core.Interfaces;
using Core.Seeding.Contract;
using System;
using System.Collections.Generic;

namespace Core.Seeding.Contracts
{
    /// <summary>
    /// Contract for data seeder
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISeeder<T> : ICommandAsync<T>
    {
        IEnumerable<ISeedDatum> SeedData { get; }

        ISeederContext SeederContext { get; }
    }
}
