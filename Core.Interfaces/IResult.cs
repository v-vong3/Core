using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    /// <summary>
    /// Contract for a generic response
    /// </summary>
    public interface IResult
    {
        TimeSpan Duration { get; }

        bool HasFailed { get; }

        string ErrorMessage { get; }

        object Data { get; } 
    }

    /// <summary>
    /// Contract for a generic response
    /// </summary>
    /// <typeparam name="T">The desired data type of <c>IResult.Data</c></typeparam>
    public interface IResult<T>
    {
        TimeSpan Duration { get; }

        bool HasFailed { get; }

        string ErrorMessage { get; }

        T Data { get;  }
    }
}
