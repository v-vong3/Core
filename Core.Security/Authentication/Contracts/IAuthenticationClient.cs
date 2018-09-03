using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;

namespace Core.Security.Authentication.Contracts
{
    public interface IAuthenticationClient
    {

        ClaimsIdentity CreateIdentity(string username, IEnumerable<Claim> claims);

        ClaimsPrincipal CreatePrincipal(IIdentity identity);

        string GeneratePasswordHash(string password, byte[] salt, byte[] iv);

        string IsMatch(string passwordHash);


    }
}
