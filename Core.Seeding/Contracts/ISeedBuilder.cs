using Core.Interfaces;
using Core.Seeding.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Seeding.Contracts
{
    public interface ISeedBuilder : IBuilderAsync<IEnumerable<ISeedDatum>>
    {
        /// <summary>
        /// Adds new data to be seeded
        /// </summary>
        /// <remarks>
        /// The input will be boxed as an <see cref="ISeedDatum"/> for consistency.  It is the
        /// responsibility of the concrete <see cref="ISeeder{T}"/> to unbox and process the raw data.
        /// </remarks>
        /// <param name="data">Collection of objects</param>
        /// <returns>The same instance to enable fluent API</returns>
        ISeedBuilder Add(IEnumerable<object> data);

        /// <summary>
        /// Removes all <see cref="ISeedDatum"/> consisting of the same <see cref="Type"/>
        /// </summary>
        /// <param name="type">The type of the seed data</param>
        /// <returns></returns>
        ISeedBuilder Remove(Type type);

        /// <summary>
        /// Clears all configured <see cref="ISeedDatum"/> from the builder
        /// </summary>
        /// <returns>The same instance to enable fluent API</returns>
        ISeedBuilder Clear();

    }
}
