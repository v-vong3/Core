using System.Collections.Generic;
using System.Security.Claims;

namespace Core.Security.Authorization.Contracts
{
    public interface IAuthorizationClient
    {
        // TODO: Determine ambient context to apply claims against

        bool HasAccess(IEnumerable<Claim> claims);
    }
}
