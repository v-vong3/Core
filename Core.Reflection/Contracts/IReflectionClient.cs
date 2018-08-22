using System;
using System.Reflection;

namespace Core.Reflection.Contracts
{
    public interface IReflectionClient : IDisposable
    {
        string BaseAssemblyPath { get; }

        Assembly CurrentAssembly { get; }
    }
}
