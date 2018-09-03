using Core.Interfaces;

namespace Core.Security.Cryptography.Contracts
{
    public interface ISymmetricCryptoClient
    {
        byte[] Key { get; set; }

        byte[] IV { get; set; }

        string KeyText { get; }

        string IVText { get; }

        IResult<string> Encrypt(string plaintext);

        IResult<string> Decrypt(string ciphertext);
    }
}
