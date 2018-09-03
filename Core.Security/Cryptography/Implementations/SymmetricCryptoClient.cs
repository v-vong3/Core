using Core.Interfaces;
using Core.Security.Cryptography.Contracts;
using System;
using System.Text;

namespace Core.Security.Cryptography.Implementations
{
    public class SymmetricCryptoClient : ISymmetricCryptoClient
    {
        public SymmetricCryptoClient(byte[] key, byte[] iv)
        {
            // TODO: Verify encoding of both parameters as ASCII, Invariant Culture

            Key = key;
            IV = iv;
        }

        public SymmetricCryptoClient(string key, string iv)
        {
            // Assumes both parameters are ASCII encoded, culture info

            Key = Encoding.ASCII.GetBytes(key);
            IV = Encoding.ASCII.GetBytes(iv);
        }

        public byte[] Key { get; set; }
        public byte[] IV { get; set; }

        public string KeyText => Encoding.ASCII.GetString(Key);

        public string IVText => Encoding.ASCII.GetString(IV);


        public IResult<string> Decrypt(string ciphertext)
        {
            throw new NotImplementedException();
        }

        public IResult<string> Encrypt(string plaintext)
        {
            throw new NotImplementedException();
        }

    }
}
