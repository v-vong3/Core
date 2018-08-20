using Core.Interfaces;
using Core.Security.Cryptography.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Security.Cryptography.Implementations
{
    public class CryptoClient : ICryptoClient
    {
        private static byte[] IV { get; set; }
        private static string Key { get; set; }



        public IResult<string> Decrypt(string ciphertext)
        {
            throw new NotImplementedException();
        }

        public IResult<string> Encrypt(string plaintext)
        {
            throw new NotImplementedException();
        }

        public ICryptoClient SetInjectionVector(byte[] iv)
        {
            throw new NotImplementedException();
        }

        public ICryptoClient SetKey(string key)
        {
            throw new NotImplementedException();
        }
    }
}
