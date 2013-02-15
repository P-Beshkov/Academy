//10. Write a program that finds in given array of integers a 
//sequence of given sum S (if present). 
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}
using System;

class Program
{
    static int rangeSum = 0;
    static int[] array = { 4, 3, 1, 4, 2, 5, 8 };
    private static void PrintSum(int startIndex, int endIndex)
    {
        for (int i = startIndex; i < endIndex; i++)
        {
            Console.Write("{0} + ", array[i]);
        }
        Console.WriteLine("\b\b= {0}", rangeSum);
    }
    static void Main()
    {
        Console.Write("Array size = ");
        int size = int.Parse(Console.ReadLine());
        array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Sum for search = ");
        rangeSum = int.Parse(Console.ReadLine());

        for (int rangeCount = 0; rangeCount < array.Length; rangeCount++)
        {
            for (int firstElementPosition = 0; firstElementPosition < array.Length - rangeCount; firstElementPosition++)
            {
                int currentSum = 0;
                for (int count = firstElementPosition; count < rangeCount + firstElementPosition; count++)
                {
                    currentSum += array[count];
                }
                if (currentSum == rangeSum)
                {
                    PrintSum(firstElementPosition, firstElementPosition+rangeCount);

                }
            }
        }
    }
}

