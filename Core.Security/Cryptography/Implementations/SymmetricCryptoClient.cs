using Core.Interfaces;
using Core.Security.Cryptography.Contracts;
using System;

namespace Core.Security.Cryptography.Implementations
{
    public class SymmetricCryptoClient : ISymmetricCryptoClient
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

        public ISymmetricCryptoClient SetInjectionVector(byte[] iv)
        {
            throw new NotImplementedException();
        }

        public ISymmetricCryptoClient SetKey(string key)
        {
            throw new NotImplementedException();
        }
    }
}
