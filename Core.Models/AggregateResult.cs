using Core.Interfaces;
using System;
using System.Collections.Generic;

namespace Core.Models
{
    /// <summary>
    /// Weak-typed response object for aggregate results
    /// </summary>
    public class AggregateResult : IAggregateResult
    {
        public TimeSpan Duraction { get; set; }

        public ICollection<IResult> Results { get; }

        public AggregateResult()
        {
            Results = new List<IResult>();
        }
    }

    /// <summary>
    /// Strongly-typed response object for aggregate results
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AggregateResult<T> : IAggregateResult<T> where T : class, new()
    {
        public TimeSpan Duraction { get; set; }

        public ICollection<IResult<T>> Results { get; }

        public AggregateResult()
        {
            Results = new List<IResult<T>>();
        }
    }
}
