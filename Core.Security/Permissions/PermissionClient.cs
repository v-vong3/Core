using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

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
