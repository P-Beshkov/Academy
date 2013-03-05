/*02. Implement a set of extension methods for IEnumerable<T> that 
* implement the following group functions: sum, product, min, max, average. */

using System;
using System.Collections.Generic;
using System.Linq;

public static class IEnumerableExtensions
{
    public static dynamic Sum<T>(this IEnumerable<T> collection)
    {
        dynamic sum = 0;
        foreach (var item in collection)
        {
            sum += item;
        }
        return sum;
    }

    public static dynamic Product<T>(this IEnumerable<T> collection)
    {
        dynamic sum = 1;
        foreach (var item in collection)
        {
            sum *= item;
        }
        return sum;
    }

    public static dynamic Min<T>(this IEnumerable<T> collection)
    {
        dynamic min = collection.First();
        
        foreach (var item in collection)
        { 
            if (item < min)
            {
                min = item;
            }
        }
        return min;
    }

    public static dynamic Max<T>(this IEnumerable<T> collection)
    {
        dynamic max = collection.First();

        foreach (var item in collection)
        {
            if (item > max)
            {
                max = item;
            }
        }
        return max;
    }

    public static dynamic Average<T>(this IEnumerable<T> collection)
    {
        return (decimal)collection.Sum() / collection.Count();      
    }
}