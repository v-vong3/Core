using Core.Interfaces;

namespace Core.Security.Cryptography.Contracts
{
    public interface IBlockchain : IHashable, IVerifiable
    {
        // TODO: Decide between string vs byte[] vs both

        byte[] BlockKey { get; set; }

        string BlockKeyText { get; }

        byte[] BlockDigest { get; set; }

        string BlockDigestText { get; }

    }

}