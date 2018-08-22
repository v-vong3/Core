using System.Collections.Generic;
using System.Security.Claims;

namespace Core.Security.Permissions
{
    public interface IPermissionClient
    {
        // TODO: Determine ambient context to apply claims against

        bool HasAccess(IEnumerable<Claim> claims);
    }
}
