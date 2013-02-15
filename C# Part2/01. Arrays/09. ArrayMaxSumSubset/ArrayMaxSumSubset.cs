//08. Write a program that finds the sequence of maximal sum in given array. 
//Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> elementsIndex = new List<int>();
        
        Console.Write("Array size = ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        int subsetSize;
        int currentSum = 0;
        long maxSum = long.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        for (subsetSize = 1; subsetSize <= size; subsetSize++)
        {
            for (int j = 0; j <= array.Length - subsetSize; j++)
            {
                List<int> tempIndex = new List<int>();
                for (int i = j; i < j + subsetSize; i++)
                {
                    currentSum += array[i];
                    tempIndex.Add(i);
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    elementsIndex = new List<int>(tempIndex);
                }
                currentSum = 0;
            }
        }
        Console.WriteLine("Max sum = {0}", maxSum);
        Console.Write("Of elements = ");
        foreach (int item in elementsIndex)
        {
            Console.Write("{0}, ", array[item]);
        }
        Console.WriteLine();
    }
}