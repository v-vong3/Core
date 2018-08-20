using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class AggregateResult : IAggregateResult
    {
        public TimeSpan Duraction { get; set; }

        public ICollection<IResult> Results { get; }

        public AggregateResult()
        {
            Results = new List<IResult>();
        }
    }


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
