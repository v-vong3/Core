using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    /// <summary>
    /// Contract for 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IStrategy<T> : ICommand<IResult<T>>
    {
        string Name { get; }
    }

    public interface IStrategy : IStrategy<IResult>
    { }

    public interface IStrategyAsync<T> : ICommandAsync<T>
    {
        string Name { get; }
    }

    public interface IStrategyAsync : IStrategyAsync<IResult>
    { }


}
