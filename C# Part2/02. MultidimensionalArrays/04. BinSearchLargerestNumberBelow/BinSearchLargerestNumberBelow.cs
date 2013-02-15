//04. Write a program, that reads from the console an array of N integers 
//and an integer K, sorts the array and using the method Array.BinSearch() 
//finds the largest number in the array which is ≤ K. 

using System;

class BinSearchLargerestNumberBelow
{
    static void Main()
    {
        int[] array = { 3, 2, 6, 12, 32, -23, 1, 0, 433 };
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        Array.Sort(array);
        foreach (int item in array)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
        if (k < array[0])
        {
            Console.WriteLine("Element is not in the array!");
        }
        else
        {
            int index = Array.BinarySearch(array, k);
            if (index < 0)
            {
                index = ~index - 1;
            }
            Console.WriteLine("Largest number <=K [{0}] = {1}", index, array[index]);
        }
    }
}

