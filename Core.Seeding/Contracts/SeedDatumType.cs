﻿namespace Core.Seeding.Contracts
{
    /// <summary>
    /// Defines all of the valid types of <see cref="ISeedDatum"/>
    /// </summary>
    public enum SeedDatumType
    {
        Unknown = 0,
        POCO = 1,
        Command = 2,
        File = 3,
        Web
    }
}
