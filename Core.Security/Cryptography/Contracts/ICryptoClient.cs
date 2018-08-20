using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Security.Cryptography.Contracts
{
    public interface ICryptoClient
    {
        ICryptoClient SetKey(string key);

        ICryptoClient SetInjectionVector(byte[] iv);

        IResult<string> Encrypt(string plaintext);

        IResult<string> Decrypt(string ciphertext);
    }
}
