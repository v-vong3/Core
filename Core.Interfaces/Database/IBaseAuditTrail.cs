using System;


namespace Core.Interfaces.Database
{
    public interface IBaseAuditTrail
    {
        DateTime? UpdateDate { get; set; }

        string CreateBy { get; set; }

        string UpdateBy { get; set; }
    }
}
