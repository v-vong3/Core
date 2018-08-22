using Core.Interfaces;

namespace Core.Security.Cryptography.Contracts
{
    public interface ISymmetricCryptoClient
    {
        ISymmetricCryptoClient SetKey(string key);

        ISymmetricCryptoClient SetInjectionVector(byte[] iv);

        IResult<string> Encrypt(string plaintext);

        IResult<string> Decrypt(string ciphertext);
    }
}
