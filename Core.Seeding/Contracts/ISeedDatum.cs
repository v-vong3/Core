using System;

namespace Core.Seeding.Contracts
{
    /// <summary>
    /// Contract for unifying seed data structure 
    /// </summary>
    public interface ISeedDatum
    {
        int Order { get; set; }

        /// <summary>
        /// Secondary sort criteria (ascending order aka older seeds are pushed to the back) 
        /// for determining the processing order of each datum
        /// </summary>
        /// <remarks>
        /// This property is meant to add transparency into how data will be seeded 
        /// </remarks>
        DateTime DateAdded { get; }

        object Value { get; }

        Type ValueType { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <completionlist cref="SeedDatumType"/>
        SeedDatumType DatumType { get; }

    }
}
