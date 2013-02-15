//4. Write a program that finds the maximal sequence of equal elements 
//in an array. Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Array size = ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        int currentRange = 1,
        maxRange = 0,
        maxRangeElement = 0,
        i = 0;

        for (i = 0; i < array.Length; i++)
        {
            Console.Write("{0} element = ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        for (i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                currentRange++;
            }
            else
            {
                if (currentRange > maxRange)
                {
                    maxRange = currentRange;
                    maxRangeElement = array[i];
                }
                currentRange = 1;
            }
        }
        if (currentRange > maxRange)
        {
            maxRange = currentRange;
            maxRangeElement = array[i];
        }
        Console.WriteLine("Max range is with \nlength = {0}\nelement = {1}", maxRange, maxRangeElement);
    }
}