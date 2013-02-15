//06. Write a program that reads two integer numbers 
//N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.

using System;

class MaxSumOfElements
{
    static void Main()
    {
        Console.Write("Enter N(array size) = ");
        int arraySize = int.Parse(Console.ReadLine());
        int[] array = new int[arraySize];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("[{0}] = ",i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter K(element count) = ");
        int elementCount = int.Parse(Console.ReadLine());

        int sum = 0;
        Console.Write("Elements: ");
        for (int i = 0; i < elementCount; i++)
        {
            int currentMaxValue = array[0];
            int index;
            int tempIndex = 0;
            for (index = 1; index < array.Length; index++)
            {
                if (array[index] > currentMaxValue)
                {
                    currentMaxValue = array[index];
                    tempIndex=index;
                }
            }
            Console.Write("[{0}], ",tempIndex);
            sum += currentMaxValue;
            array[tempIndex] = int.MinValue;
        }
        Console.WriteLine();
        Console.WriteLine("Sum is = {0}",sum);


    }
}