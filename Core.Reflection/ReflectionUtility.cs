using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Core.Reflection
{
    public class ReflectionUtility : IDisposable
    {
        
        public string BaseAssemblyPath { get; }


        public ReflectionUtility(string baseAssemblyPath)
        {
            BaseAssemblyPath = baseAssemblyPath;
        }


        public IEnumerable<Type> GetExportedTypes(string assemblyName)
        {
            if(string.IsNullOrWhiteSpace(assemblyName))
            {
                throw new ArgumentNullException($"Parameter [{nameof(assemblyName)}] cannot be null, empty or whitespace.");
            }

            var fullyQualifiedPath = Path.Combine(BaseAssemblyPath, assemblyName);

            if(!File.Exists(fullyQualifiedPath))
            {
                throw new ArgumentException($"File [{assemblyName}] does not exist.");
            }

            var assembly = Assembly.LoadFile(fullyQualifiedPath);

            return assembly.ExportedTypes;
        }


        public IEnumerable<MethodInfo> GetMethods(string assemblyName, string typeName)
        {
            if(string.IsNullOrWhiteSpace(typeName))
            {
                throw new ArgumentNullException($"Parameter [{nameof(typeName)}] cannot be null, empty or whitespace.");
            }

            var type = GetExportedTypes(assemblyName).FirstOrDefault(t => t.Name == typeName);

            return type.GetRuntimeMethods();  // TODO: Evaluate between GetMethods()
        }

         

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion

    }
}
