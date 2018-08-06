using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Logging
{
    public enum LogLevel
    {
        Null = 0, // Log message will be a NOOP
        Debug,
        Info,
        Warning,
        Error,
        Critical
    }
}
