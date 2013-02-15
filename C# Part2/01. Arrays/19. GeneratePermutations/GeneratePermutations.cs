//19.* Write a program that reads a number N and generates and 
//prints all the permutations of the numbers [1 … N]. 
//Example: n=3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

using System;
class GeneratePermutations
{
    static byte[] used;
    static int[] mp;
    static void MyPermutations(int i, int n)
    {
        if (i == (n + 1))
        {
            Console.Write("{");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0}, ", mp[i]);
            }
            Console.WriteLine("\b\b}");
            return;
        }
        for (int p = 1; p <= n; p++)
        {
            if (used[p] == 0)
            {
                used[p] = 1;
                mp[i] = p;
                MyPermutations(i + 1, n);
                used[p] = 0;
            }
        }
    }
    static void Main(string[] args)
    {
        Console.Write("N = ");
        int numbersCount = int.Parse(Console.ReadLine());
        used = new byte[numbersCount+1];
        mp = new int[numbersCount+1];
        MyPermutations(1, numbersCount);
        Console.ReadKey();
    }
}

