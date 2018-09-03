namespace Core.Security.Cryptography.Contracts
{
    public interface IBlockKeyRule
    {
        // TODO: Decide between string vs byte[] vs both
        bool HasPass(string blockDigest);

        bool HasPass(byte[] blockDigest);
    }
}
