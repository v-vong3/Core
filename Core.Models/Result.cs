using System;
using Core.Interfaces;

namespace Core.Models
{
    public class Result : IResult
    {
        public TimeSpan Duration { get; }
        public bool HasFailed { get; } = true;
        public string ErrorMessage { get; }
        public object Data { get; }


        public Result()
        {

        }
    }


    public class Result<T> : IResult<T> where T : class, new()
    {
        public Result(TimeSpan duration, bool hasFailed, string errorMessage, T data)
        {
            Duration = duration;
            HasFailed = hasFailed;
            ErrorMessage = errorMessage;
            Data = data;
        }

        public TimeSpan Duration { get; }
        public bool HasFailed { get; }
        public string ErrorMessage { get; }
        public T Data { get; }


    }
}
