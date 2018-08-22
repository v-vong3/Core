using Core.Interfaces;

namespace Core.Security.Cryptography.Contracts
{
    public interface IBlockchain : IHashable, IVerifiable
    {
        string BlockKey { get; set; }

        string BlockDigest { get; set; }

    }

}