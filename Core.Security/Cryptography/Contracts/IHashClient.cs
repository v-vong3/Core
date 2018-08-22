namespace Core.Security.Cryptography.Contracts
{
    public interface IHashClient
    {
        string ComputeHash(string message);

    }
}
