using System;

namespace Domain.Common
{
    public class Result<T> : IResult<T>
    {
        public bool IsOk { get; private set; }
        public T value { get; private set; }
        public Exception exception { get; private set; }
        
        public static Result<T> Success(T res)
        {
            Result<T> r = new Result<T>();
            r.IsOk = true;
            r.value = res;
            return r;
        }

        public static Result<T> Failure(Exception exception)
        {
            Result<T> r = new Result<T>();
            r.IsOk = false;
            r.exception = exception;
            return r;
        }
    }
}
