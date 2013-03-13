using System;

class InvalidRangeException<T> : ApplicationException
{
    private T start;
    private T end;

    public InvalidRangeException(string message, T start, T end) : base(message,null)
    {
    }

    public InvalidRangeException(string message, T start, T end, Exception causeException) : base(message, causeException)
    {
        this.start = start;
        this.end = end;
    }
}