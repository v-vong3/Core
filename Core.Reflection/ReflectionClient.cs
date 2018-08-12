using Core.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Core.Reflection
{
    /// <summary>
    /// Client for simple code introspection
    /// </summary>
    public class ReflectionClient : IReflectionClient
    {
        
        public string BaseAssemblyPath { get; private set; }

        public Assembly CurrentAssembly { get; private set; }

        /// <summary>
        /// Creates an instance of <see cref="ReflectionClient"/>
        /// </summary>
        /// <param name="baseAssemblyPath">Fully-qualified physical directory path</param>
        public ReflectionClient(string baseAssemblyPath)
        {
            Guard.AgainstNonExistentPath(baseAssemblyPath, nameof(baseAssemblyPath));

            BaseAssemblyPath = baseAssemblyPath;
        }

        public ReflectionClient(Assembly assembly)
        {
            Guard.AgainstNullArgument(assembly, nameof(assembly));

            CurrentAssembly = assembly;
            BaseAssemblyPath = CurrentAssembly.Location;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="assemblyName"></param>
        /// <returns></returns>
        public IEnumerable<Type> GetExportedTypes(string assemblyName)
        {
            if(string.IsNullOrWhiteSpace(assemblyName))
            {
                throw new ArgumentNullException($"Parameter [{nameof(assemblyName)}] cannot be null, empty or whitespace.");
            }

            var fullyQualifiedPath = Path.Combine(BaseAssemblyPath, assemblyName);

            if(!File.Exists(fullyQualifiedPath))
            {
                throw new ArgumentException($"Invalid parameter value.  Assembly [{assemblyName}] does not exist at the specified location.");
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

            return type.GetRuntimeMethods();  // TODO: Evaluate pros/cons with GetMethods()
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

                BaseAssemblyPath = null;
                CurrentAssembly = null;

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
