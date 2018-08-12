﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Core.Reflection
{
    public interface IReflectionClient : IDisposable
    {
        string BaseAssemblyPath { get; }

        Assembly CurrentAssembly { get; }
    }
}
