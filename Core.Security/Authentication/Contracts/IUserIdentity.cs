using System;
using System.Security.Principal;

namespace Core.Security.Authentication.Contracts
{
    public interface IUserIdentity : IIdentity
    {
        string Username { get; }

        // DESIGN: DateOfBirth must be UTC  
        DateTime DOB { get; }

        // TODO: Decide if culture and location information properties should be added 
        // or defined as security claims

    }
}
