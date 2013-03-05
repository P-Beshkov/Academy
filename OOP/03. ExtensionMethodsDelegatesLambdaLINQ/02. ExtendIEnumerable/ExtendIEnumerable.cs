/*02. Implement a set of extension methods for IEnumerable<T> that 
* implement the following group functions: sum, product, min, max, average. */

using System;
using System.Collections.Generic;

class ExtendIEnumerable
{
    static void Main()
    {
        int[] arr = new int[10];
        List<int> list = new List<int>();
        list.Add(10);
        list.Add(-23);
        list.Add(15);
        Console.WriteLine("Sum = " + list.Sum());
        Console.WriteLine("Product = " + list.Product());
        Console.WriteLine("Min = " + list.Min());
        Console.WriteLine("Max = " + list.Max());
        Console.WriteLine("Average = " + list.Average());
    }
}