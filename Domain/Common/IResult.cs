using System;

namespace Domain.Common
{
    public interface IResult<T>
    {
        Exception exception { get; }
        bool IsOk { get; }
        T value { get; }
    }
}