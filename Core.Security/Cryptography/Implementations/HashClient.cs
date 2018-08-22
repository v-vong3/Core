using Core.Security.Cryptography.Contracts;
using System.Security.Cryptography;
using System.Text;

namespace Core.Security.Cryptography.Implementations
{
    public class HashClient : IHashClient
    {
        private Encoding HashEncoding { get; }
        private string Key { get; }
        private KeyedHashAlgorithm KeyedHashAlgorithm { get; }


        private byte[] KeyBytes => HashEncoding.GetBytes(Key ?? string.Empty);


        public HashClient(string key, Encoding encoding = null)
        {
            // TODO: Add guards

            Key = key;
            HashEncoding = encoding ?? Encoding.ASCII;
        }


        public string ComputeHash(string message)
        {
            // TODO: Decide if hard-coding to HMAC256 is best to promote simplicity over extensibility

            using (var hmac = new HMACSHA256(KeyBytes))
            {
                var messageBytes = HashEncoding.GetBytes(message);

                var digest = hmac.ComputeHash(messageBytes);

                return HashEncoding.GetString(digest);
            }
        }
    }
}
