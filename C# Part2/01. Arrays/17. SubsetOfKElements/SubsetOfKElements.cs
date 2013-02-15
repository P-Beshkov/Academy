//17. * Write a program that reads three integer numbers N, K and S and
//an array of N elements from the console. Find in the array a subset 
//of K elements that have sum S or indicate about its absence.

using System;


class Program
{
    static long sumOriginal;
    static long[] values = { 0, 2, 1, 2, 4, 3, 5, 2, 6 };
    static int[] position;
    static int foundSubsets = 0;


    static void GenerateCombinaton(int genForPosition, int after, int numbersToCombine)
    {
        if (genForPosition > numbersToCombine)
        {
            long checkSum = 0;
            for (genForPosition = 0; genForPosition < numbersToCombine; genForPosition++)
            {
                checkSum += values[position[genForPosition]];
            }
            if (sumOriginal == checkSum)
            {
                foundSubsets++;
                Console.Write("yes (");
                for (genForPosition = 0; genForPosition < numbersToCombine; genForPosition++)
                {
                    Console.Write(values[position[genForPosition]] + " + ");
                }
                Console.Write("\b\b) = {0} ", checkSum);
                Console.WriteLine();
            }

            return;
        }
        for (int p = (after + 1); p <= values.Length - 1; p++)
        {
            position[genForPosition - 1] = p;
            GenerateCombinaton(genForPosition + 1, p, numbersToCombine);
        }
    }
    static void Main()
    {
        Console.Write("N (array size) = ");
        int arrSize = int.Parse(Console.ReadLine());
        values = new long[arrSize];
        for (int i = 0; i < arrSize; i++)
        {
            Console.Write("[{0}] = ",i);
            values[i] = int.Parse(Console.ReadLine());
        }
        position = new int[values.Length];
        Console.Write("K (numbers to combine) = ");
        int numbersToCombine = int.Parse(Console.ReadLine());
        Console.Write("S (sum to search for) = ");
        sumOriginal = long.Parse(Console.ReadLine());
        GenerateCombinaton(1, 0, numbersToCombine);
        if (foundSubsets == 0)
        {
            Console.WriteLine("Subset not found!");
        }
    }
}
