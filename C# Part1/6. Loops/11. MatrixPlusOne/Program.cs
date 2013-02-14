//Write a program that reads from the console a positive integer 
//number N (N < 20) and outputs a matrix like the following:

using System;

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        uint n = uint.Parse(Console.ReadLine());

        for (int i = 1; i <=n; i++)
        {
            for (int j = i; j < (n+i); j++)
            {
                Console.Write("{0,3}",j);
            }
            Console.WriteLine();
        }
    }
}