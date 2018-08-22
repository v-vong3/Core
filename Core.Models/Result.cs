using Core.Interfaces;
using System;

namespace Core.Models
{
    /// <summary>
    /// Weak-typed response object
    /// </summary>
    public class Result : IResult
    {
        public TimeSpan Duration { get; set; }
        public string ErrorMessage { get; set; }
        public object Data { get; set; }

        public bool HasFailed => string.IsNullOrWhiteSpace(ErrorMessage);
    }

    /// <summary>
    /// Strongly-typed response object
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Result<T> : IResult<T> where T : class, new()
    {
        public TimeSpan Duration { get; set; }
        public string ErrorMessage { get; set; }
        public T Data { get; set; }


        public bool HasFailed => string.IsNullOrWhiteSpace(ErrorMessage);

    }
}
