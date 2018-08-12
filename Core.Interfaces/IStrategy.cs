using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    /// <summary>
    /// Contract for a synchronous Strategy Pattern
    /// </summary>
    /// <typeparam name="T">The desired data type of the return value</typeparam>
    public interface IStrategy<T> : ICommand<IResult<T>>
    {
        string Name { get; }
    }

    /// <summary>
    /// Contract for a synchronous Strategy Pattern
    /// </summary>
    public interface IStrategy : IStrategy<IResult>
    { }



    /// <summary>
    /// Contract for an asynchronous Strategy Pattern
    /// </summary>
    /// <typeparam name="T">The desired data type of the return value</typeparam>
    public interface IStrategyAsync<T> : ICommandAsync<T>
    {
        string Name { get; }
    }

    /// <summary>
    /// Contract for an asynchronous Strategy Pattern
    /// </summary>
    public interface IStrategyAsync : IStrategyAsync<IResult>
    { }


}
