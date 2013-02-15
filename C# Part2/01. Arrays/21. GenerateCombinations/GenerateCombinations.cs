//21. Write a program that reads two numbers N and K and generates
//all the combinations of K distinct elements from the set [1..N]. 
//Example: N=5, K=2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;

class GenerateCombinations
{    
    static long[] values;
    static int[] position;
    static int numbersToCombine;
    static void GenerateCombinaton(int genForPosition, int after)
    {
        if (genForPosition > numbersToCombine)
        {
            Console.Write("{");
            for (genForPosition = 0; genForPosition < numbersToCombine; genForPosition++)
            {
                Console.Write("{0}, ", values[position[genForPosition]]);
            }
            Console.WriteLine("\b\b}");
            return;
        }
        for (int p = (after + 1); p <= values.Length - 1; p++)
        {
            position[genForPosition - 1] = p;
            GenerateCombinaton(genForPosition + 1, p);
        }
    }
    static void Main()
    {
        Console.Write("K (elements) = ");
        numbersToCombine = int.Parse(Console.ReadLine());
        Console.Write("N (from) = ");
        int numbersCount = int.Parse(Console.ReadLine());
        values = new long[numbersCount];
        for (int i = 1; i <= numbersCount; i++)
        {
            values[i - 1] = i;
        }
        position = new int[values.Length];
        GenerateCombinaton(1, -1);
        Console.ReadKey();

    }
}