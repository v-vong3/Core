using Core.Interfaces;
using System;
using System.Threading.Tasks;

namespace Core.Security.Cryptography.Contracts
{
    public interface IHashable
    {
        string PreHashContent { get; }
    }

}
