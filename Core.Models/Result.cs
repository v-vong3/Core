using System;
using System.Diagnostics;
using Core.Interfaces;

namespace Core.Models
{
    public class Result : IResult
    {
        public TimeSpan Duration { get; set; }
        public string ErrorMessage { get; set; }
        public object Data { get; set; }

        public bool HasFailed => string.IsNullOrWhiteSpace(ErrorMessage);
    }


    public class Result<T> : IResult<T> where T : class, new()
    {
        public TimeSpan Duration { get; set; }
        public string ErrorMessage { get; set; }
        public T Data { get; set; }


        public bool HasFailed => string.IsNullOrWhiteSpace(ErrorMessage);

    }
}
