using Core.Security.Authorization.Contracts;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Core.Security.Authorization.Implementations
{
    public class AuthorizationClient : IAuthorizationClient
    {
        public bool HasAccess(IEnumerable<Claim> claims)
        {
            throw new NotImplementedException();
        }
    }
}
