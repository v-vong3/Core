using System;

namespace Core.Interfaces
{
    /// <summary>
    /// Contract for a generic response
    /// </summary>
    public interface IResult
    {
        TimeSpan Duration { get; set; }

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
        TimeSpan Duration { get; set; }

        bool HasFailed { get; }

        string ErrorMessage { get; set; }

        T Data { get; set; }
    }
}
