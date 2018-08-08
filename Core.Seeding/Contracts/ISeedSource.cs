using Core.Seeding.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Seeding.Contracts
{
    public interface ISeedSource
    {
        IEnumerable<ISeedDatum> SeedData { get; set; }

        IEnumerable<string> SeedScripts { get; set; }
    }
}
