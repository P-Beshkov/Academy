﻿/*03. Define a class InvalidRangeException<T> that holds information about 
* an error condition related to invalid range. It should hold error message 
* and a range definition [start … end].
* Write a sample application that demonstrates the InvalidRangeException<int> 
* and InvalidRangeException<DateTime> by entering numbers in the range [1..100] 
* and dates in the range [1.1.1980 … 31.12.2013]. */

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int p;
        Console.WriteLine("Enter integer in range [1..100]: ");
        p = int.Parse(Console.ReadLine());
        if (p < 0 || p > 100)
        {
            throw new InvalidRangeException<int>("Value must be in range[1..100]", 1, 100);
        }

        Console.WriteLine("Enter date in range[1.1.1980-31.12.2013]:");
        DateTime date = new DateTime();
        date = DateTime.Parse(Console.ReadLine());
    }
}

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