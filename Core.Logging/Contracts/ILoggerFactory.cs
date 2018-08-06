using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Logging.Contracts
{
    public interface ILoggerFactory : IFactory<ILoggerAsync>
    { }
}
