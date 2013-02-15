//20. Write a program that reads two numbers N and K and generates 
//all the variations of K elements from the set [1..N]. 
//Example:N=3, K=2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;

class GenerateVariations
{    
    static int[] mp;
    static int numbersToCombine;
    static void MyPermutations(int i, int n)
    {
        if (i == (numbersToCombine+1))
        {
            Console.Write("{");
            for (i = 1; i <= numbersToCombine; i++)
            {
                Console.Write("{0}, ", mp[i]);
            }
            Console.WriteLine("\b\b}");
            return;
        }
        for (int p = 1; p <= n; p++)
        {
            mp[i] = p;
            MyPermutations(i + 1, n);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("K = ");
        numbersToCombine = int.Parse(Console.ReadLine());
        Console.Write("N = ");
        int numbersCount = int.Parse(Console.ReadLine());
        mp = new int[numbersCount + 1];
        MyPermutations(1, numbersCount);
        Console.ReadKey();
    }
}
