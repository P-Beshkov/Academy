/*05. Write a program that prints from given array of integers all 
* numbers that are divisible by 7 and 3. Use the built-in extension 
* methods and lambda expressions. Rewrite the same with LINQ. */

using System;
using System.Collections.Generic;
using System.Linq;

class PrintSpecificNumbersFromArray
{
    static void Main()
    {
        int[] array = new int[1000];

        for (int i = 0; i < 1000; i++)
        {
            array[i] = i;
        }

        var divisible = array.Where((x) => x % 3 == 0 && x % 7 == 0);
        Console.WriteLine("Values matched by lambda");
        foreach (int item in divisible)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        divisible =
                   from values in array
                   where values % 3 == 0 && values % 7 == 0
                   select values;
        Console.WriteLine("\nValues matched by LINQ");
        foreach (int item in divisible)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}