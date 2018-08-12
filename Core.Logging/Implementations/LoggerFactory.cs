using Core.Logging.Contracts;
using Core.Reflection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Core.Logging.Implementations
{
    public class LoggerFactory : ILoggerFactory
    {
        public ILoggerAsync CreateInstance(string type)
        {
            var reflectionClient = new ReflectionClient(Assembly.GetExecutingAssembly());

            throw new NotImplementedException();
        }
    }
}
