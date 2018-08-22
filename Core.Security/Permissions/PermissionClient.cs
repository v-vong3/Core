using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Core.Security.Permissions
{
    public class PermissionClient : IPermissionClient
    {
        public bool HasAccess(IEnumerable<Claim> claims)
        {
            throw new NotImplementedException();
        }
    }
}
