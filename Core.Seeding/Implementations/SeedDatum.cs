using Core.Seeding.Contracts;
using System;

namespace Core.Seeding
{
    /// <summary>
    /// A single element for seeding
    /// </summary>
    public class SeedDatum : ISeedDatum
    {
        public object Value { get; }
        public Type ValueType { get; }
        public SeedDatumType DatumType { get; }
        public DateTime DateAdded { get; }

        public SeedDatum(object value, Type valueType, SeedDatumType datumType)
        {
            Value = value;
            ValueType = valueType;
            DatumType = datumType;

            // DESIGN: All date-related entities must use UTC format to account for time inconsistencies
            // such as leap year & daylight savings time
            DateAdded = DateTime.UtcNow;  
        }

        public int Order { get; set; } = 1;


    }
}
