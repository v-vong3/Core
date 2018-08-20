using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    /// <summary>
    /// Contract for an aggregated response
    /// </summary>
    public interface IAggregateResult
    {
        /// <summary>
        /// The total duration to process all results
        /// </summary>
        TimeSpan Duraction { get; set; }

        ICollection<IResult> Results { get; }
    }

    /// <summary>
    /// Contract for a generic aggregated response
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IAggregateResult<T>
    {
        /// <summary>
        /// The total duration to process all results
        /// </summary>
        TimeSpan Duraction { get; set; }

        ICollection<IResult<T>> Results { get; }
    }
}
