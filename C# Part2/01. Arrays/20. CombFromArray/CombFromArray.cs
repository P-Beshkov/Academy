//16. * We are given an array of integers and a number S. Write a program to 
//find if there exists a subset of the elements of the array that has a sum S. 
//Example: 	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

using System;
class Program
{
    static long sumOriginal;
    static long[] values = { 0, 2, 1, 2, 4, 3, 5, 2, 6 };
    static int[] position = new int[values.Length];


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
        Console.Write("S = ");
        sumOriginal = long.Parse(Console.ReadLine());
        for (int numbersToCombine = 1; numbersToCombine <= values.Length; numbersToCombine++)
        {
            GenerateCombinaton(1, 0, numbersToCombine);
        }

    }
}

