using System;
using System.Collections.Generic;
using System.Text;

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
