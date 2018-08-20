using System;

namespace Core.Interfaces.Database
{
    public interface IBaseEntity
    {
        string Id { get; set; }

        DateTime CreateDate { get; set; }

    }
}
