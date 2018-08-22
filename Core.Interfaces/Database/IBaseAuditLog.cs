using System;

namespace Core.Interfaces.Database
{
    public interface IBaseAuditLog
    {
        string EntityName { get; set; }

        string AttributeName { get; set; }

        string NewValue { get; set; }

        DateTime ChangeDate { get; set; }

        string ChangeBy { get; set; }

    }
}
