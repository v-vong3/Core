using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public interface IBaseEntity
    {
        string Id { get; set; }

        DateTime CreateDate { get; set; }

        DateTime? UpdateDate { get; set; }

        string CreateBy { get; set; }

        string UpdateBy { get; set; }

    }
}
