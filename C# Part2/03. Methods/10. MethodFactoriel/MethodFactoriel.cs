//10. Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number represented as 
//array of digits by given integer number. 

using System;
using System.Numerics;

class MethodFactoriel
{
    static private BigInteger Factoriel (int n)
    {
        BigInteger result =1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
    static void Main(string[] args)
    {
        Console.Write("Calculate factorial of: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Result: {0}",Factoriel(n));
    }
}