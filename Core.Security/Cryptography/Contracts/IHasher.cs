using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Security.Cryptography.Contracts
{
    public interface IHasher
    {
        string ComputeHash();

    }
}
