using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Seeding.Contracts
{
    /// <summary>
    /// Contract for registering and unregistering seeding data sources
    /// </summary>
                                    
    public interface ISeedBuilder 
        : IBuilderAsync<IOrderedEnumerable<ISeedDatum>> // DESIGN: Enforcing a sorted collection to guarantee order of enumeration
    {
        /// <summary>
        /// Registers <see cref="ISeedDatum"/> wrapped POCOs for data seed process  
        /// </summary>
        /// <remarks>
        /// The input will be boxed as an <see cref="ISeedDatum"/> for interface extensibility.  It is the
        /// responsibility of the concrete <see cref="ISeeder{T}"/> to unbox and process the raw data.
        /// </remarks>
        /// <param name="seedData">Collection of <see cref="ISeedDatum"/></param>
        /// <returns>The current builder instance to enable fluent API</returns>
        ISeedBuilder Add(params ISeedDatum[] seedData);


        /// <summary>
        /// Removes all <see cref="ISeedDatum"/> having matching <see cref="ISeedDatum.ValueType"/>
        /// </summary>
        /// <param name="type">The <see cref="Type"/> of the raw data</param>
        /// <returns>The current builder instance to enable fluent API</returns>
        ISeedBuilder Remove(Type type);


        /// <summary>
        /// Removes all <see cref="ISeedDatum"/> having matching <see cref="ISeedDatum.DatumType"/>
        /// </summary>
        /// <param name="datumType">The <see cref="SeedDatumType"/>The type of the seed datum</param>
        /// <returns></returns>
        ISeedBuilder Remove(SeedDatumType datumType);


        /// <summary>
        /// Unregisters all <see cref="ISeedDatum"/>
        /// </summary>
        /// <returns>The current builder instance to enable fluent API</returns>
        ISeedBuilder Clear();

    }
}
