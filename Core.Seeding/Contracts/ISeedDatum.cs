using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Seeding.Contract
{
    /// <summary>
    /// Contract for unifying seed data structure 
    /// </summary>
    public interface ISeedDatum
    {
        int Order { get; set; }

        /// <summary>
        /// Secondary sort criteria (descending order) for determining the 
        /// processing order of each datum
        /// </summary>
        /// <remarks>
        /// This property is meant to add transparency into how data will be seeded 
        /// </remarks>
        DateTime DateAdded { get; }

        object Value { get; }

        Type Type { get; }
    }
}
