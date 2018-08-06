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
        bool HasFailed { get; }

        string ErrorMessage { get; set; }

        object Data { get; set; } 
    }

    /// <summary>
    /// Contract for a generic response
    /// </summary>
    /// <typeparam name="T">The desired data type of <c>IResult.Data</c></typeparam>
    public interface IResult<T>
    {
        bool HasFailed { get; }

        string ErrorMessage { get; set; }

        T Data { get; set; }
    }
}
