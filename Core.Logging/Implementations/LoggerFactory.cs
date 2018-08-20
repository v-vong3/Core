using Core.Logging.Contracts;
using Core.Reflection;
using Core.Reflection.Implementations;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Core.Logging.Implementations
{
    public class LoggerFactory : ILoggerFactory
    {
        private readonly static Assembly _assembly = _assembly ?? typeof(LoggerFactory).Assembly;

        public ILoggerAsync CreateInstance(string type)
        {
            var reflectionClient = new ReflectionClient(_assembly);

            // TODO: Finish implementation of reflection


            throw new NotImplementedException();
        }
    }
}
