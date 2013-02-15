//5. Write a program that finds the maximal increasing sequence in 
//an array. Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

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
        i = 0;

        for (i = 0; i < array.Length; i++)
        {
            Console.Write("[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        
        int endMaxIndex= 0;
        for ( i = 0; i < array.Length - 1; i++)
        {
            if (array[i] <= array[i + 1])
            {
                currentRange++;
            }
            else
            {
                if (currentRange > maxRange)
                {
                    endMaxIndex = i;
                    maxRange = currentRange;
                }
                currentRange = 1;
            }
        }

        Console.WriteLine("Max range end index = {0}",endMaxIndex);
        Console.WriteLine("length = {0}",maxRange);
    }
}