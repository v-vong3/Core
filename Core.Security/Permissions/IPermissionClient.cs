using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Core.Security.Permissions
{
    public interface IPermissionClient
    {
        // TODO: Determine ambient context

        bool HasAccess(IEnumerable<Claim> claims);
    }
}
